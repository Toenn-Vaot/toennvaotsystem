namespace ToennVaot.Components.Core.Exceptions
{
    /// <summary>
    /// This enumeration lists all available exceptions in CORE component
    /// </summary>
    public enum CoreExceptionCodeEnum
    {
        /// <summary>
        /// StateOverflowException
        /// </summary>
        StateOverflowException = 1,
        /// <summary>
        /// RecordDeletionForbiddenException
        /// </summary>
        RecordDeletionForbiddenException = 2,
        /// <summary>
        /// RecordCreationForbiddenException
        /// </summary>
        RecordCreationForbiddenException = 3,
        /// <summary>
        /// RecordAlreadyExistsException
        /// </summary>
        RecordAlreadyExistsException = 4,
        /// <summary>
        /// RecordNotExistsException
        /// </summary>
        RecordNotExistsException = 5,
        /// <summary>
        /// RecordNotValidException
        /// </summary>
        RecordNotValidException = 6,
        /// <summary>
        /// RecordUpdateForbiddenException
        /// </summary>
        RecordUpdateForbiddenException = 7,
        /// <summary>
        /// MissingPropertyValueException
        /// </summary>
        MissingPropertyValueException = 8
    }
}
