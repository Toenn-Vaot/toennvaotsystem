using System.Text;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ToennVaot.Components.Core.Api.Filters.Swagger
{
    /// <summary>
    /// Operation filter to display the restrictions applied on the endpoint
    /// </summary>
    public class SwaggerDisplayObsoleteOperationFilter : IOperationFilter
    {
        /// <inheritDoc/>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var attributes = context.ApiDescription.CustomAttributes().ToList();
            if (attributes.Count == 0)
                return;

            var obsolete = attributes.Any(a => a is ObsoleteAttribute);
            if (obsolete)
            {
                var summaryBuilder = new StringBuilder();
                var descriptionBuilder = new StringBuilder();

                var obsoleteFilter = (ObsoleteAttribute)attributes.First(a => a is ObsoleteAttribute);
                summaryBuilder.AppendLine($"DEPRECATED {(!string.IsNullOrWhiteSpace(operation.Summary) ? $" - {operation.Summary}" : "")} - REMOVED in the next version");
                descriptionBuilder.AppendLine($"**Deprecated reason:** _{(!string.IsNullOrWhiteSpace(obsoleteFilter.Message) ? obsoleteFilter.Message : "none")}_");
                descriptionBuilder.AppendLine("<br/><br/>");

                operation.Summary = summaryBuilder.ToString();

                descriptionBuilder.AppendLine(operation.Description);
                operation.Description = descriptionBuilder.ToString();
            }
        }
    }
}