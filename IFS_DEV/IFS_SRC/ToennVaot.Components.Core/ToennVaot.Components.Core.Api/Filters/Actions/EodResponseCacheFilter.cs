using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;

namespace ToennVaot.Components.Core.Api.Filters.Actions
{
    /// <summary>
    /// The End Of Day response cache filter
    /// </summary>
    public class EodResponseCacheFilter : IActionFilter
    {
        /// <summary>
        /// The configuration instance
        /// </summary>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration">The configuration instance</param>
        public EodResponseCacheFilter(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <inheritdoc />
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var triggeredHour = int.Parse(Configuration["EndOfDay:Hour"] ?? "2");
            var addADay = DateTime.Now.Hour < triggeredHour ? 0 : 1;

            context.HttpContext.Response.GetTypedHeaders().CacheControl = new CacheControlHeaderValue
            {
                MaxAge = TimeSpan.FromSeconds((DateTime.Now.Date.AddDays(addADay).AddHours(triggeredHour) - DateTime.Now).TotalSeconds),
                Public = true
            };
        }

        /// <inheritdoc />
        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}
