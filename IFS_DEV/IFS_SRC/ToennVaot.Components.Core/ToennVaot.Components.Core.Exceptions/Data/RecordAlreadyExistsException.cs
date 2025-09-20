namespace ToennVaot.Components.Core.Exceptions.Data
{
    /// <summary>
    /// Exception triggers when the record already exists
    /// </summary>
    /// <typeparam name="T">The record type</typeparam>
    public abstract class RecordAlreadyExistsException<T> : BaseCoreException
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected RecordAlreadyExistsException(Enum value)
        : base(value, $"The record of type {nameof(T)} already exists")
        {
        }
    }
}