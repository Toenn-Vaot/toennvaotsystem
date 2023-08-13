using System.Security.Claims;
using OpenIddict.Abstractions;

namespace ToennVaot.Components.Core.Api.Extensions
{
    /// <summary>
    /// This class extends the <see cref="ClaimsPrincipal"/>
    /// </summary>
    public static class ClaimsPrincipalExtensions
    {
        /// <summary>
        /// Indicates if the <paramref name="principal"/> has been provided through a customer authentication
        /// </summary>
        /// <param name="principal">The claims principal instance</param>
        /// <returns>True if claims principal has grant type client credentials</returns>
        public static bool IsCustomerAuthentication(this ClaimsPrincipal principal)
        {
            return (principal.Claims.FirstOrDefault(c => c.Type == Constants.Security.ClaimType.GrantType)?.Value ?? string.Empty) != OpenIddictConstants.GrantTypes.ClientCredentials;
        }

        /// <summary>
        /// Indicates if the <paramref name="principal"/> has been provided through an application authentication
        /// </summary>
        /// <param name="principal">The claims principal instance</param>
        /// <returns>True if claims principal has grant type authorization code</returns>
        public static bool IsApplicationAuthentication(this ClaimsPrincipal principal)
        {
            return (principal.Claims.FirstOrDefault(c => c.Type == Constants.Security.ClaimType.GrantType)?.Value ?? string.Empty) != OpenIddictConstants.GrantTypes.AuthorizationCode;
        }

        /// <summary>
        /// Indicates if the <paramref name="principal"/> has been provided through a device authentication
        /// </summary>
        /// <param name="principal">The claims principal instance</param>
        /// <returns>True if claims principal has grant type device code</returns>
        public static bool IsDeviceAuthentication(this ClaimsPrincipal principal)
        {
            return (principal.Claims.FirstOrDefault(c => c.Type == Constants.Security.ClaimType.GrantType)?.Value ?? string.Empty) != OpenIddictConstants.GrantTypes.DeviceCode;
        }
    }
}
