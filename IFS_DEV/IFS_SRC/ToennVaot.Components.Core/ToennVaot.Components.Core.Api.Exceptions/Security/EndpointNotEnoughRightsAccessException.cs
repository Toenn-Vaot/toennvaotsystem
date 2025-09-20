using ToennVaot.Components.Core.Exceptions;

namespace ToennVaot.Components.Core.Api.Exceptions.Security;

/// <summary>
/// Exception triggers when the user try to access endpoint with insufficient rights
/// </summary>
public class EndpointNotEnoughRightsAccessException : BaseCoreException
{
    /// <summary>
    /// Constructor
    /// </summary>
    public EndpointNotEnoughRightsAccessException(Enum value)
        : base(value, "The user has insufficient rights to access this endpoint")
    {
            
    }
}