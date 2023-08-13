using Microsoft.AspNetCore.Authorization;

namespace ToennVaot.Components.Core.Security.Permissions
{
    /// <inheritdoc />
    public class PermissionAuthorizationRequirement : IAuthorizationRequirement
    {
        /// <summary>
        /// The issuer
        /// </summary>
        public string Issuer { get; }

        /// <summary>
        /// The permission name
        /// </summary>
        public string PermissionName { get; }

        /// <summary>
        /// Constructor with permission name and the issuer
        /// </summary>
        /// <param name="permission">The permission name</param>
        /// <param name="issuer">The issuer</param>
        public PermissionAuthorizationRequirement(string permission, string issuer)
        {
            PermissionName = permission ?? throw new ArgumentNullException(nameof(permission));
            Issuer = issuer ?? throw new ArgumentNullException(nameof(issuer));
        }
    }
}
