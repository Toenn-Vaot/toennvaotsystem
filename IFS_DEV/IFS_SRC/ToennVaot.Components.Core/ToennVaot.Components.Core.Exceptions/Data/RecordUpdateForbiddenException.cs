namespace ToennVaot.Components.Core.Exceptions.Data;

/// <summary>
/// Exception triggers when the update of record is forbidden
/// </summary>
/// <typeparam name="T">The record type</typeparam>
public class RecordUpdateForbiddenException<T> : BaseCoreException
{
    /// <summary>
    /// Constructor
    /// </summary>
    public RecordUpdateForbiddenException(Enum value)
        : base(value, $"The record of type {nameof(T)} can't be updated")
    {
            
    }
}