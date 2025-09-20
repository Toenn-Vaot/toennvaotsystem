namespace ToennVaot.Components.Core.Exceptions.Security;

/// <summary>
/// Exception triggers when the call to the operation is done with insufficient rights
/// </summary>
public class EndpointNotEnoughRightsOperationException : BaseCoreException
{
    /// <summary>
    /// Constructor
    /// </summary>
    public EndpointNotEnoughRightsOperationException(Enum value)
        : base(value, "The operation requested on this endpoint can't be done due to insufficient rights")
    {
            
    }
}