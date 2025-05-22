namespace ToennVaot.Components.Core.Api.Exceptions
{
    /// <summary>
    /// Exception triggered when a property value is missing (null or empty) for the configured flow
    /// </summary>
    public class MissingJsonPropertyValueException : Exception
    {
        /// <summary>
        /// The property name for which miss the value
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="propertyName">The property name for which miss the value</param>
        public MissingJsonPropertyValueException(string propertyName)
        : base($"The property {propertyName} is null or empty but the configured flow require a value.")
        {
            PropertyName = propertyName;
        }
    }
}
