using Microsoft.OpenApi;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ToennVaot.Components.Core.Api.Filters.Swagger
{
    /// <summary>
    /// Operation filter to add default values in swagger documentation 
    /// </summary>
    public class SwaggerDefaultValuesOperationFilter : IOperationFilter
    {
        /// <inheritdoc />
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var apiDescription = context.ApiDescription;
            apiDescription.TryGetMethodInfo(out var methodInfo);
            var obsolete = methodInfo.CustomAttributes.Any(x => x.AttributeType == typeof(ObsoleteAttribute));

            operation.Deprecated |= obsolete;

            if (operation.Parameters == null)
            {
                return;
            }

            foreach (var parameter in operation.Parameters)
            {
                var description = apiDescription.ParameterDescriptions.First(p => p.Name == parameter.Name);

                parameter.Description ??= description.ModelMetadata?.Description;
            }
        }
    }
}
