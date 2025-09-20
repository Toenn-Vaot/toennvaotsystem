using Newtonsoft.Json;

namespace ToennVaot.Components.Core.Exceptions
{
    /// <summary>
    /// This class describes the base component exception.
    /// This class should be used as base for all components of sub-system
    /// </summary>
    public abstract class BaseComponentException<T> : Exception where T : Enum
    {
        /// <summary>
        /// The linked component
        /// </summary>
        public abstract T Component { get; }

        /// <summary>
        /// The exception code value
        /// </summary>
        public int ExceptionCode { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        protected BaseComponentException(int value, string message)
            : base(message)
        {
            ExceptionCode = value;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        protected BaseComponentException(Enum value, string message)
            : this(Convert.ToInt32(value), message)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        protected BaseComponentException(Enum value, string message, Exception innerException)
            : base(message, innerException)
        {
            ExceptionCode = Convert.ToInt32(value);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return JsonConvert.SerializeObject(new { component = int.Parse(Component.ToString()), code = ExceptionCode, message = Message });
        }
    }
}
