using ToennVaot.Components.Core.Models;

namespace ToennVaot.Components.Core.Interfaces
{
    /// <summary>
    /// Interface defines the based store methods
    /// </summary>
    public interface IStore
    {

    }

    /// <summary>
    /// Interface defines the based store methods with model
    /// </summary>
    public interface IStore<TU, TUser> : IStore 
        where TU : class
    {
        /// <summary>
        /// Add a new item to the store
        /// </summary>
        /// <typeparam name="T">The model type of the object to add</typeparam>
        /// <param name="item">The item to add</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>The request result</returns>
        Task<ManagerRequestResult> Add<T>(T item, TUser user);

        /// <summary>
        /// Set a new item to the store
        /// </summary>
        /// <typeparam name="T">The model type of the object to set</typeparam>
        /// <param name="item">The item to set</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>The request result</returns>
        Task<ManagerRequestResult> Set<T>(T item, TUser user);
    }

    /// <summary>
    /// Interface defines the based store methods with model
    /// </summary>
    public interface IStoreChangedState<TU, TUser> : IStore 
        where TU : class
    {
        /// <summary>
        /// Change the state of the item to the store
        /// </summary>
        /// <param name="item">The item to change state</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>The request result</returns>
        Task<ManagerRequestResult> ChangeState(IStateRecord item, TUser user);
    }

    /// <summary>
    /// Interface defines the based store methods with model
    /// </summary>
    public interface IStoreDeletable<TU, TUser> : IStore 
        where TU : class
    {
        /// <summary>
        /// Delete the item to the store
        /// </summary>
        /// <param name="item">The item to delete</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>The request result</returns>
        Task<ManagerRequestResult> Delete(IDeletableRecord item, TUser user);
    }
}