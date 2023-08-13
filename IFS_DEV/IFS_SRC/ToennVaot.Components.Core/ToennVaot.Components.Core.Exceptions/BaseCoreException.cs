namespace ToennVaot.Components.Core.Exceptions
{
    /// <summary>
    /// This class describes the base CORE exception.
    /// This class should be used as base for CORE component exceptions
    /// </summary>
    public abstract class BaseCoreException : BaseComponentException
    {
        /// <inheritdoc />
        public override ComponentSubSystemEnum Component => ComponentSubSystemEnum.Core;

        /// <inheritdoc />
        protected BaseCoreException(Enum value, string message) : base(value, message)
        {
        }

        /// <inheritdoc />
        protected BaseCoreException(Enum value, string message, Exception innerException) : base(value, message, innerException)
        {
        }
    }
}
