using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ToennVaot.Components.Core.Api.Extensions;

namespace ToennVaot.Components.Core.Api.Filters.Swagger
{
    /// <summary>
    /// Action filter attribute to filter action when customer identifier is a part of request path
    /// </summary>
    public class ApplicationOnlyAuthenticationModeFilterAttribute : ActionFilterAttribute
    {
        /// <inheritdoc />
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Check if Customer authentication
            var principal = context.HttpContext.User;
            if (!principal.IsApplicationAuthentication())
            {
                context.Result = new StatusCodeResult((int)HttpStatusCode.Forbidden);
                return;
            }

            base.OnActionExecuting(context);
        }
    }
}