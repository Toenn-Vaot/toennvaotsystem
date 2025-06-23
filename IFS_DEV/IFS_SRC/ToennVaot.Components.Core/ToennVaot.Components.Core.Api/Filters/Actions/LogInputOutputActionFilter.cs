using System.Net;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ToennVaot.Components.Core.Api.Filters.Actions
{
    /// <summary>
    /// Action filter to log input and output of API action
    /// </summary>
    public class LogInputOutputActionFilter : IActionFilter
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">The logger instance</param>
        public LogInputOutputActionFilter(ILogger logger)
        {
            _logger = logger;
        }

        /// <inheritdoc />
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var uri = context.HttpContext.Request.GetDisplayUrl();
            var status = (HttpStatusCode) Enum.Parse(typeof(HttpStatusCode), context.HttpContext.Response.StatusCode.ToString());
            _logger.LogInformation("RESPONSE [{Uri}] - {StatusName:G}({StatusValue:D})", uri, status, status);
        }

        /// <inheritdoc />
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var uri = context.HttpContext.Request.GetDisplayUrl();
            var parameters = context.ActionDescriptor.Parameters.Select(x => new { x.Name, Value = context.RouteData.Values[x.Name] });

            _logger.LogInformation("CALL [{Uri}]:{Parameters}", uri, JsonConvert.SerializeObject(parameters, Formatting.None));
        }
    }
}
