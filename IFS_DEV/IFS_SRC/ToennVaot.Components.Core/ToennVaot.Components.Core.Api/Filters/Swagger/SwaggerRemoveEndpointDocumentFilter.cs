using System.Reflection;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using ToennVaot.Components.Core.Api.Filters.Actions;

namespace ToennVaot.Components.Core.Api.Filters.Swagger
{
    /// <summary>
    /// Operation filter to display the restrictions applied on the endpoint
    /// </summary>
    public class SwaggerRemoveEndpointDocumentFilter : IDocumentFilter
    {
        /// <inheritdoc />
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            foreach (var contextApiDescription in context.ApiDescriptions)
            {
                var actionDescriptor = (ControllerActionDescriptor)contextApiDescription.ActionDescriptor;

                if (actionDescriptor.ControllerTypeInfo.GetCustomAttributes<SwaggerRemoveControllerFilterAttribute>().Any() 
                    || actionDescriptor.MethodInfo.GetCustomAttributes<SwaggerRemoveActionAttribute>().Any())
                {
                    var key = "/" + contextApiDescription.RelativePath.TrimEnd('/');
                    swaggerDoc.Paths.Remove(key);
                }
            }
        }
    }
}
