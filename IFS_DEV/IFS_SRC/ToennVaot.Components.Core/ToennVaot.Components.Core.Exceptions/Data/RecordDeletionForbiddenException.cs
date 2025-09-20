namespace ToennVaot.Components.Core.Exceptions.Data
{
    /// <summary>
    /// Exception triggers when the deletion of record is forbidden
    /// </summary>
    /// <typeparam name="T">The record type</typeparam>
    public abstract class RecordDeletionForbiddenException<T> : BaseCoreException
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected RecordDeletionForbiddenException(Enum value)
        : base(value, $"The record of type {nameof(T)} can't be deleted")
        {
                
        }
    }
}
