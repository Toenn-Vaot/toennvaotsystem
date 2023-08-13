namespace ToennVaot.Components.Core.Security
{
    /// <summary>
    /// This enumeration lists all available application authentication flow types
    /// </summary>
    public enum ApplicationAuthenticationFlowTypeEnum
    {
        /// <summary>
        /// Implicit
        /// </summary>
        Implicit,
        /// <summary>
        /// Client credentials
        /// </summary>
        ClientCredentials,
        /// <summary>
        /// Authorization code
        /// </summary>
        AuthorizationCode
    }
}
