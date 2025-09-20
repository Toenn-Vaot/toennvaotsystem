namespace ToennVaot.Components.Core.Exceptions.Data
{
    /// <summary>
    /// Exception triggers when the record is not valid
    /// </summary>
    /// <typeparam name="T">The record type</typeparam>
    public abstract class RecordNotValidException<T> : BaseCoreException
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected RecordNotValidException(Enum value)
        : base(value, $"The record of type {nameof(T)} is not valid")
        {
        }
    }
}