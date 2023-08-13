namespace ToennVaot.Components.Core.Exceptions.Security;

/// <summary>
/// Exception triggers when the call to the operation is done with insufficient rights
/// </summary>
public class NotEnoughRightsOperationException : BaseCoreException
{
    /// <summary>
    /// Constructor
    /// </summary>
    public NotEnoughRightsOperationException(Enum value)
        : base(value, "The operation requested can't be done due to insufficient rights")
    {
            
    }
}