using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using ToennVaot.Components.Core.Security.Permissions;

namespace ToennVaot.Components.Core.Api.Security.Attributes
{
    /// <summary>
    /// Authorize attribute to apply permission restrictions
    /// </summary>
    /// <seealso cref="AuthorizeAttribute"/>
    /// <seealso cref="PermissionEnum"/>
    public class AuthorizeOIDCAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AuthorizeOIDCAttribute()
        {
            AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme;
        }

        /// <summary>
        /// Constructor with permission
        /// </summary>
        /// <param name="permissions">The list of permissions to apply</param>
        public AuthorizeOIDCAttribute(params PermissionEnum[] permissions)
        : base(string.Join(",", permissions)) { }
    }
}
