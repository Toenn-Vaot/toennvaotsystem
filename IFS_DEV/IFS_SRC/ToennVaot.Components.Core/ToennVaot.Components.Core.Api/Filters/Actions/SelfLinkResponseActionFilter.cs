using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ToennVaot.Components.Core.Api.Extensions;
using ToennVaot.Components.Core.Api.Models.Hal;

namespace ToennVaot.Components.Core.Api.Filters.Actions
{
    /// <summary>
    /// Action filter to add its proper URL in result HAL object
    /// </summary>
    public class SelfLinkResponseActionFilter : IActionFilter
    {
        /// <inheritdoc />
        public void OnActionExecuting(ActionExecutingContext context)
        {
        }

        /// <inheritdoc />
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var result = context.Result as ObjectResult;
            if (result?.Value is Representation representation)
            {
                var underlyingType = representation.GetType();
                var halCollection = underlyingType.GetProperties().Where(x => x.PropertyType.IsGenericType && x.PropertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>) && x.PropertyType.GetGenericArguments()[0].IsSubclassOf(typeof(Representation)));

                if (context.Controller is ControllerBase controller)
                {
                    var controllerName = controller.ControllerContext.ActionDescriptor.ControllerName;
                    var actionName = controller.ControllerContext.ActionDescriptor.ActionName;
                    var routeValues = controller.ControllerContext.ActionDescriptor.RouteValues;

                    representation.AddSelfRelation(controller.Url.Action(actionName, controllerName, routeValues), new HttpMethod(context.HttpContext.Request.Method));
                }
            }
        }
    }
}
