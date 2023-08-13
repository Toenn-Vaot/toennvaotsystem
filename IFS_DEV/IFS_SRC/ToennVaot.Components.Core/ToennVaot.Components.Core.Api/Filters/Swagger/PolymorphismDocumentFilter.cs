using System.Reflection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ToennVaot.Components.Core.Api.Filters.Swagger
{
    /// <summary>
    /// The polymorphism filter to add into the document the derived classes
    /// </summary>
    /// <typeparam name="T">The abstract/base class to integrate derivations</typeparam>
    public class PolymorphismDocumentFilter<T> : IDocumentFilter
    {
        private readonly List<Type> _derivedTypes = new (Init());

        /// <inheritdoc />
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            const string discriminatorName = "discriminator";

            var baseSchema = context.SchemaRepository.Schemas[typeof(T).Name];

            //Discriminator property
            baseSchema.Discriminator = new OpenApiDiscriminator { PropertyName = discriminatorName };
            baseSchema.Required = new HashSet<string> { discriminatorName };

            if (!baseSchema.Properties.ContainsKey(discriminatorName))
                baseSchema.Properties.Add(discriminatorName, new OpenApiSchema { Type = "string" });

            //Register derived classes
            foreach (var item in _derivedTypes)
                context.SchemaRepository.AddDefinition(item.Name, new OpenApiSchema { Reference = new OpenApiReference { ExternalResource = "#/definitions/" + item.Name } });
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
