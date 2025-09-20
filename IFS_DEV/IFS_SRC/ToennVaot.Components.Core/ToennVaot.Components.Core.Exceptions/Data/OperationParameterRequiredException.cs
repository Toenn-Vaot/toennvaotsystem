namespace ToennVaot.Components.Core.Exceptions.Data
{
    /// <summary>
    /// Exception triggers when an operation parameter is required but not provided.
    /// </summary>
    public abstract class OperationParameterRequiredException : BaseCoreException
    {
        /// <summary>
        /// Thrown when an operation parameter is required but not provided.
        /// </summary>
        /// <param name="value">The enumeration value</param>
        /// <param name="paramName">The missing parameter name</param>
        protected OperationParameterRequiredException(Enum value, string paramName)
            : base(value, $"The operation parameter '{paramName}' is required but was not provided.")
        {
        }
    }
}
