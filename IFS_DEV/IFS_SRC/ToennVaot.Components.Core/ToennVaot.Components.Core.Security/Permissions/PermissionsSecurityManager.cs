using System.ComponentModel;
using System.Security.Claims;

namespace ToennVaot.Components.Core.Security.Permissions
{
    /// <summary>
    /// Security manager of <seealso cref="PermissionEnum"/>
    /// </summary>
    public static class PermissionsSecurityManager
    {
        /// <summary>
        /// Check the <paramref name="requirement"/> is allowed in permission claim
        /// </summary>
        /// <param name="principal">The claims principal context</param>
        /// <param name="requirement">The permission requirement</param>
        /// <returns>True if the permission is found. Otherwise, false</returns>
        public static bool IsAllowed(ClaimsPrincipal principal, PermissionAuthorizationRequirement requirement)
        {
            return IsAllowed(principal, requirement.PermissionName);
        }

        /// <summary>
        /// Check the <paramref name="permissionName"/> is allowed in permission claim
        /// </summary>
        /// <param name="principal">The claims principal context</param>
        /// <param name="permissionName">The permission name required</param>
        /// <returns>True if the permission is found. Otherwise, false</returns>
        public static bool IsAllowed(ClaimsPrincipal principal, string permissionName)
        {
            var permissionClaim = principal.Claims.SingleOrDefault(c => c.Type == PermissionConstants.PackedPermissionClaimType);
            return permissionClaim != null && IsAllowed(permissionClaim.Value, permissionName);
        }

        /// <summary>
        /// Check the <paramref name="permissionName"/> is allowed in the string representation of permissions
        /// </summary>
        /// <param name="representation">The string representation of permissions</param>
        /// <param name="permissionName">The permission name required</param>
        /// <returns>True if the permission is found. Otherwise, false</returns>
        public static bool IsAllowed(string representation, string permissionName)
        {
            if (!Enum.TryParse(permissionName, true, out PermissionEnum permissionToCheck))
                throw new InvalidEnumArgumentException($"[{permissionName}] could not be converted to a {nameof(PermissionEnum)}.");

            var usersPermissions = PermissionsPacker.Unpack(representation).ToArray();

            return new []{ permissionToCheck, PermissionEnum.AccessAll }.Intersect(usersPermissions).Any();
        }
    }
}
