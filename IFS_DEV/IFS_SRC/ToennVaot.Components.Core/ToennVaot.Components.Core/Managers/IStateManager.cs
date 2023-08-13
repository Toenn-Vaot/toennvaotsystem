using ToennVaot.Components.Core.Exceptions;

namespace ToennVaot.Components.Core.Managers
{
    /// <summary>
    ///     The state manager interface
    /// </summary>
    /// <typeparam name="T">The enumeration type of state to manage</typeparam>
    /// <typeparam name="TU">The type of object holds the state</typeparam>
    public interface IStateManager<in TU, in T> where TU : class where T : struct
    {
        /// <summary>
        ///     Method to init the state of <paramref name="component"/>
        /// </summary>
        /// <param name="component">The component to manage</param>
        void InitState(TU component);

        /// <summary>
        ///     Method to reset the state of <paramref name="component"/>
        /// </summary>
        /// <param name="component">The component to manage</param>
        void ResetState(TU component);

        /// <summary>
        ///     Method to change the current state to the <paramref name="newState" /> of the <paramref name="component" />
        /// </summary>
        /// <param name="component">The component to manage</param>
        /// <param name="newState">The new state to set</param>
        /// <exception cref="StateOverflowException">
        ///     Exception triggers when <paramref name="newState" /> is out of the authorized
        ///     flow
        /// </exception>
        void ChangeState(TU component, T newState);
    }
}