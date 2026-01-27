using Microsoft.OpenApi;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ToennVaot.Components.Core.Api.Filters.Swagger
{
    /// <summary>
    /// Operation filter to the "X-Tenant-Id" header parameter to all API operations in Swagger documentation.
    /// </summary>
    public class SwaggerRequiredTenantHeaderParameterOperationFilter : IOperationFilter
    {
        /// <inheritdoc />
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
            {
                operation.Parameters = new List<IOpenApiParameter>();
            }

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "X-Tenant-Id",
                In = ParameterLocation.Header,
                Required = true,
                Description = "The tenant identifier",
                Schema = new OpenApiSchema
                {
                    Type = JsonSchemaType.String,
                    Format = "uuid"
                }
            });
        }
    }
}
