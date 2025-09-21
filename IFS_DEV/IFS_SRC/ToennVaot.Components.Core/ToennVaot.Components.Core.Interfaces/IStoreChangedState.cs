using ToennVaot.Components.Core.Exceptions;
using ToennVaot.Components.Core.Models;
using ToennVaot.Components.Core.Models.Interfaces;

namespace ToennVaot.Components.Core.Interfaces;

/// <summary>
/// Interface defines the based store methods with model
/// </summary>
/// <typeparam name="T">The item type to delete</typeparam>
/// <typeparam name="TState">The enumeration of states to apply</typeparam>
/// <typeparam name="TUser">The type to use to designate the user operating the actions</typeparam>
public interface IStoreChangedState<in T, in TState, in TUser> : IStore 
    where T : IStateRecord<TState>
    where TState : Enum
{
    /// <summary>
    /// Initiate the state of the item to the store
    /// </summary>
    /// <param name="item">The item to init state</param>
    /// <param name="user">The user makes the operation</param>
    /// <returns>The request result</returns>
    Task<StoreRequestResult> InitStateAsync(T item, TUser user);

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
    Task<StoreRequestResult> ChangeStateAsync(T item, TState newState, TUser user);

    /// <summary>
    /// Reset the state of the item to the store
    /// </summary>
    /// <param name="item">The item to reset state</param>
    /// <param name="user">The user makes the operation</param>
    /// <returns>The request result</returns>
    Task<StoreRequestResult> ResetStateAsync(T item, TUser user);
}