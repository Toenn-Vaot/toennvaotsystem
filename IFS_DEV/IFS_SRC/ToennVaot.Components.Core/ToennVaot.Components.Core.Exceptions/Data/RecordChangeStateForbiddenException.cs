namespace ToennVaot.Components.Core.Exceptions.Data;

/// <summary>
/// Exception triggers when the change of state of record is forbidden
/// </summary>
/// <typeparam name="T">The record type</typeparam>
public class RecordChangeStateForbiddenException<T> : BaseCoreException
{
    /// <summary>
    /// Constructor
    /// </summary>
    public RecordChangeStateForbiddenException(Enum value)
        : base(value, $"The record of type {nameof(T)} can't change state")
    {
            
    }
}