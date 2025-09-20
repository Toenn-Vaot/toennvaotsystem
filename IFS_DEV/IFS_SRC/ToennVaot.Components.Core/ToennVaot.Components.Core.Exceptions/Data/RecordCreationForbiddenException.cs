namespace ToennVaot.Components.Core.Exceptions.Data;

/// <summary>
/// Exception triggers when the creation of record is forbidden
/// </summary>
/// <typeparam name="T">The record type</typeparam>
public abstract class RecordCreationForbiddenException<T> : BaseCoreException
{
    /// <summary>
    /// Constructor
    /// </summary>
    protected RecordCreationForbiddenException(Enum value)
        : base(value, $"The record of type {nameof(T)} can't be created")
    {
                
    }
}