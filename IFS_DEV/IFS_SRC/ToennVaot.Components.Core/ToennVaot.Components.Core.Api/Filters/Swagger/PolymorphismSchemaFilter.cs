using System.Reflection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ToennVaot.Components.Core.Api.Filters.Swagger
{
    /// <summary>
    /// The polymorphism filter to add into the schema the derived classes
    /// </summary>
    /// <typeparam name="T">The abstract/base class to integrate derivations</typeparam>
    public class PolymorphismSchemaFilter<T> : ISchemaFilter
    {
        private readonly List<Type> _derivedTypes = [.. Init()];
        
        /// <inheritdoc />
        public void Apply(OpenApiSchema model, SchemaFilterContext context)
        {
            if (!_derivedTypes.Contains(context.Type)) return;

            var baseSchema = new OpenApiSchema { Reference = new OpenApiReference { ExternalResource = "#/definitions/" + typeof(T).Name } };
            var clonedBaseSchema = new OpenApiSchema
            {
                Properties = model.Properties,
                Type = model.Type,
                Required = model.Required
            };

            model.AllOf = new List<OpenApiSchema> { baseSchema, clonedBaseSchema };

            //Reset properties for they are included in allOf, should be null but code does not handle it
            model.Properties = new Dictionary<string, OpenApiSchema>();
        }

        private static IEnumerable<Type> Init()
        {
            var abstractType = typeof(T);
            var dTypes = abstractType.GetTypeInfo().Assembly
                .GetTypes()
                .Where(x => abstractType != x && abstractType.IsAssignableFrom(x));

            return dTypes.ToList();
        }
    }
}
