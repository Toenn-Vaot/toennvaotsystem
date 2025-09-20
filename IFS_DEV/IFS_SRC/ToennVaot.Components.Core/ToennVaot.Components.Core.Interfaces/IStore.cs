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
    public interface IStore<T, TKey, TUser> : IStore
        where T : class, new()
    {
        /// <summary>
        /// Get all items from the store
        /// </summary>
        /// <returns>The request result</returns>
        Task<StoreRequestResult<IEnumerable<T>>> GetAll();

        /// <summary>
        /// Get an item from the store
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>The request result</returns>
        Task<StoreRequestResult<T>> GetById(TKey id);

        /// <summary>
        /// Add a new item to the store
        /// </summary>
        /// <param name="item">The item to add</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>The request result</returns>
        Task<StoreRequestResult> Create(T item, TUser user);

        /// <summary>
        /// Set a new item to the store
        /// </summary>
        /// <param name="item">The item to set</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>The request result</returns>
        Task<StoreRequestResult> Update(T item, TUser user);
    }
}