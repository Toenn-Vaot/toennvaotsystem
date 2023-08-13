namespace ToennVaot.Components.Core.Exceptions
{
    /// <summary>
    /// Exception triggered when state is over the configured flow
    /// </summary>
    public class StateOverflowException : BaseCoreException
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="currentState">The current state</param>
        /// <param name="newState">The new desired state</param>
        public StateOverflowException(Enum currentState, Enum newState)
            : base(CoreExceptionCodeEnum.StateOverflowException, $"Object tries to change its state from {currentState} to {newState}. But it is not allowed.")
        {
        }
    }
}
