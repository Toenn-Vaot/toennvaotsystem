namespace ToennVaot.Components.Core.Exceptions.Data
{
    /// <summary>
    /// Exception triggers when the record does not exists
    /// </summary>
    /// <typeparam name="T">The record type</typeparam>
    public abstract class RecordNotExistsException<T> : BaseCoreException
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RecordNotExistsException(Enum value)
        : base(value, $"The record of type {nameof(T)} does not exists")
        {
        }
    }
}