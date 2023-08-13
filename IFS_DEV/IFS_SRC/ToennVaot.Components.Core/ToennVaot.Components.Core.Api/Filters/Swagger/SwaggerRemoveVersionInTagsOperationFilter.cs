using System.Text.RegularExpressions;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ToennVaot.Components.Core.Api.Filters.Swagger
{
    /// <summary>
    /// Operation filter to remove the version in Controller name used to defined section in API
    /// </summary>
    public class SwaggerRemoveVersionInTagsOperationFilter : IOperationFilter
    {
        /// <inheritDoc/>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var index = 0;
            foreach (var versionedTag in operation.Tags)
            {
                var tag = operation.Tags[index];
                if (tag != null)
                    tag.Name = Regex.Replace(versionedTag.Name, "V\\d+$", string.Empty);
                index++;
            }
        }
    }
}
