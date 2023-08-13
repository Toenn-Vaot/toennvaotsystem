using System.Xml.XPath;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ToennVaot.Components.Core.Api.Filters.Swagger
{
    /// <summary>
    /// Operation filter to add automatically responses in case of authorization is required on operation (i.e 401, 403, ...)
    /// </summary>
    public class SwaggerAssignOAuth2ResponsesOperationFilter : IOperationFilter
    {
        private readonly XPathNavigator _xmlNavigator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="xmlDoc">The XML document to explore to retrieve comments on method to decorate</param>
        public SwaggerAssignOAuth2ResponsesOperationFilter(IXPathNavigable xmlDoc)
        {
            _xmlNavigator = xmlDoc.CreateNavigator();
        }

        /// <inheritDoc/>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var controllerDescriptor = context.ApiDescription.ActionDescriptor as ControllerActionDescriptor;
            var responseTypes = controllerDescriptor?.MethodInfo.GetCustomAttributes(typeof(ProducesResponseTypeAttribute), true).ToList().ConvertAll(x => x as ProducesResponseTypeAttribute) ?? new List<ProducesResponseTypeAttribute>();
            var responseTypesNotInherit = controllerDescriptor?.MethodInfo.GetCustomAttributes(typeof(ProducesResponseTypeAttribute), false).ToList().ConvertAll(x => x as ProducesResponseTypeAttribute) ?? new List<ProducesResponseTypeAttribute>();

            var duplicatedResponseTypes = responseTypes.GroupBy(x => x.StatusCode).Where(x => x.Count() > 1).Select(x => x.Key).ToList();
            if (duplicatedResponseTypes.Count > 0)
            {
                var methodMemberName = XmlCommentsNodeNameHelper.GetMemberNameForMethod(context.MethodInfo);
                var methodNode = _xmlNavigator.SelectSingleNode($"/doc/members/member[@name='{methodMemberName}']");
                var responseNodesIterator = methodNode?.Select("response");

                if (responseNodesIterator != null)
                {
                    //NOTICE: Clear all duplicated responses
                    duplicatedResponseTypes.ForEach(x => operation.Responses.Remove(x.ToString()));
                    //NOTICE: Construct schemas
                    var cleanResponseSchemas = responseTypesNotInherit.Where(x => duplicatedResponseTypes.Contains(x.StatusCode)).Select(x => new { Key = x.StatusCode, Value = context.SchemaGenerator.GenerateSchema(x.Type, context.SchemaRepository) }).ToList();
                    //NOTICE: Add the responses with the entire list of responses (cleaned inherit and local ones)
                    cleanResponseSchemas.ForEach(x => operation.Responses.Add(x.Key.ToString(), new OpenApiResponse { Content = new Dictionary<string, OpenApiMediaType> { { "application/json", new OpenApiMediaType { Schema = x.Value } } } }));

                    while (responseNodesIterator.MoveNext())
                    {
                        var code = responseNodesIterator.Current?.GetAttribute("code", string.Empty);
                        if (code == null) continue;

                        var response = operation.Responses.ContainsKey(code) ? operation.Responses[code] : operation.Responses[code] = new OpenApiResponse();
                        response.Description = XmlCommentsTextHelper.Humanize(responseNodesIterator.Current.InnerXml);
                    }
                }
            }

            // Determine if the operation has the Authorize attribute
            var hasAuthorizeAttributes = context.ApiDescription.ActionDescriptor.FilterDescriptors.Where(x => x.Filter.GetType() == typeof(AuthorizeFilter)).Select(x => (AuthorizeFilter)x.Filter).Any();
            var hasAuthorizeControllerAttributes = (context.ApiDescription.ActionDescriptor as ControllerActionDescriptor)?.ControllerTypeInfo.GetCustomAttributes(typeof(AuthorizeAttribute), true).Any() ?? false;

            if (hasAuthorizeAttributes || hasAuthorizeControllerAttributes)
            {
                operation.Responses.Add("401", new OpenApiResponse { Description = "Unauthorized" });
                operation.Responses.Add("403", new OpenApiResponse { Description = "Forbidden" });
            }

            operation.Responses.Add("415", new OpenApiResponse { Description = "Bad Media Type - Could be request body is empty or not in a right JSON format" });
            operation.Responses.Add("500", new OpenApiResponse { Description = "Server Error" });
        }
    }
}
