using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ToennVaot.Components.Core.Api.Infrastructure
{
    /// <summary>
    /// API Version selector class
    /// </summary>
    public class VersionedActionSelector : ApiVersionActionSelector
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="actionDescriptorCollectionProvider">The action descriptor collection provider</param>
        /// <param name="actionConstraintProviders">The action constraint providers</param>
        /// <param name="options">The options</param>
        /// <param name="loggerFactory">The logger factory</param>
        /// <param name="routePolicy">The route policy</param>
        public VersionedActionSelector(IActionDescriptorCollectionProvider actionDescriptorCollectionProvider, IEnumerable<IActionConstraintProvider> actionConstraintProviders, IOptions<ApiVersioningOptions> options, ILoggerFactory loggerFactory, IApiVersionRoutePolicy routePolicy) : base(actionDescriptorCollectionProvider, actionConstraintProviders, options, loggerFactory, routePolicy)
        {
        }
        
        /// <inheritdoc />
        public override ActionDescriptor SelectBestCandidate(RouteContext context, IReadOnlyList<ActionDescriptor> candidates)
        {
            if (candidates.Count == 1)
                return base.SelectBestCandidate(context, candidates);

            var versionUrl = context.RouteData.Values["version"]?.ToString() ?? "999.0";
            return candidates.FirstOrDefault(x => x.IsMappedTo(ApiVersion.Parse(versionUrl)));
        }
    }
}
