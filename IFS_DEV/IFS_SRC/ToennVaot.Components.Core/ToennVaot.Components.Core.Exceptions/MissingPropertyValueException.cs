namespace ToennVaot.Components.Core.Exceptions
{
    /// <summary>
    /// Exception triggered when property value is missing
    /// </summary>
    public class MissingPropertyValueException : BaseCoreException
    {
        /// <inheritdoc />
        public MissingPropertyValueException(string property) 
            : base(CoreExceptionCodeEnum.MissingPropertyValueException, $"The {property} value is missing")
        {
        }

        /// <inheritdoc />
        public MissingPropertyValueException(string property, Exception innerException) 
            : base(CoreExceptionCodeEnum.MissingPropertyValueException, $"The {property} value is missing", innerException)
        {
        }
    }
}