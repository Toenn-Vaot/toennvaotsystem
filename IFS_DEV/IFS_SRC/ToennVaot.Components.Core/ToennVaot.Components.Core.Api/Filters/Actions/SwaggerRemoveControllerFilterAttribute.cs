using Microsoft.AspNetCore.Mvc.Filters;

namespace ToennVaot.Components.Core.Api.Filters.Actions
{
    /// <summary>
    /// This attribute is used to tag an API controller to be removed of the swagger documentation
    /// </summary>
    public class SwaggerRemoveControllerFilterAttribute : ActionFilterAttribute
    {
    }
}