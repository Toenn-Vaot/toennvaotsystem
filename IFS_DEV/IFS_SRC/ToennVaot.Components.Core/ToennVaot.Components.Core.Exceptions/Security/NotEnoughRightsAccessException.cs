namespace ToennVaot.Components.Core.Exceptions.Security;

/// <summary>
/// Exception triggers when the user try to access with insufficient rights
/// </summary>
public class NotEnoughRightsAccessException : BaseCoreException
{
    /// <summary>
    /// Constructor
    /// </summary>
    public NotEnoughRightsAccessException(Enum value)
        : base(value, "The user has insufficient rights to access")
    {
            
    }
}