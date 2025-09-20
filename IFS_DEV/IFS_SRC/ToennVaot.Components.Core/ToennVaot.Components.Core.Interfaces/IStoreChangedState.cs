using ToennVaot.Components.Core.Exceptions;
using ToennVaot.Components.Core.Models;
using ToennVaot.Components.Core.Models.Interfaces;

namespace ToennVaot.Components.Core.Interfaces;

/// <summary>
/// Interface defines the based store methods with model
/// </summary>
public interface IStoreChangedState<T, TState, TUser> : IStore 
    where T : IStateRecord<TState>
    where TState : Enum
{
    /// <summary>
    /// Initiate the state of the item to the store
    /// </summary>
    /// <param name="item">The item to init state</param>
    /// <param name="user">The user makes the operation</param>
    /// <returns>The request result</returns>
    Task<StoreRequestResult> InitState(T item, TUser user);

    /// <summary>
    /// Change the state of the item to the store
    /// </summary>
    /// <param name="item">The item to change state</param>
    /// <param name="newState">The new state value</param>
    /// <param name="user">The user makes the operation</param>
    /// <returns>The request result</returns>
    /// <exception cref="StateOverflowException">
    ///     Exception triggers when <paramref name="newState" /> is out of the authorized
    ///     flow
    /// </exception>
    Task<StoreRequestResult> ChangeState(T item, TState newState, TUser user);

    /// <summary>
    /// Reset the state of the item to the store
    /// </summary>
    /// <param name="item">The item to reset state</param>
    /// <param name="user">The user makes the operation</param>
    /// <returns>The request result</returns>
    Task<StoreRequestResult> ResetState(T item, TUser user);
}