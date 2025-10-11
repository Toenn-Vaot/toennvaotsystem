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
    /// <typeparam name="T">The item type to delete</typeparam>
    /// <typeparam name="TKey">The type of the item key</typeparam>
    /// <typeparam name="TUser">The type to use to designate the user operating the actions</typeparam>
    public interface IStore<T, TKey, in TUser> : IStore
        where T : class, new()
    {
        /// <summary>
        /// Get all items from the store
        /// </summary>
        /// <returns>The request result</returns>
        Task<StoreRequestResult<IEnumerable<T>>> GetAllAsync();

        /// <summary>
        /// Get an item from the store
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>The request result</returns>
        Task<StoreRequestResult<T>> GetByIdAsync(TKey id);

        /// <summary>
        /// Add a new item to the store
        /// </summary>
        /// <param name="item">The item to add</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>The request result</returns>
        Task<StoreRequestResult<TKey>> CreateAsync(T item, TUser user);

        /// <summary>
        /// Set a new item to the store
        /// </summary>
        /// <param name="item">The item to set</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>The request result</returns>
        Task<StoreRequestResult> UpdateAsync(T item, TUser user);
    }
}