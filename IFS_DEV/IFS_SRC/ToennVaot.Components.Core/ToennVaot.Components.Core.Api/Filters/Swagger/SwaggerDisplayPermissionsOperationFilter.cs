using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using ToennVaot.Components.Core.Api.Security.Attributes;

namespace ToennVaot.Components.Core.Api.Filters.Swagger
{
    /// <summary>
    /// Operation filter to display the permissions required to use the endpoint
    /// </summary>
    public class SwaggerDisplayPermissionsOperationFilter : IOperationFilter
    {
        /// <inheritDoc/>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var attributes = context.ApiDescription.CustomAttributes();
            if (attributes == null)
                return;

            var permissions = attributes
                .OfType<AuthorizeOIDCAttribute>()
                .Where(a => a.Policy != null)
                .Select(a => a.Policy)
                .FirstOrDefault();

            operation.Description = "**Permissions required:** " + (string.IsNullOrWhiteSpace(permissions) ? "None" : permissions);
        }
    }
}
