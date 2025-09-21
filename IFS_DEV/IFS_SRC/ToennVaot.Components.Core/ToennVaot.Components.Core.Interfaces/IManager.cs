using ToennVaot.Components.Core.Models;

namespace ToennVaot.Components.Core.Interfaces
{
    /// <summary>
    /// Interface defines the based manager
    /// </summary>
    public interface IManager
    {

    }

    /// <summary>
    /// Interface defines the based manager methods to manage items
    /// </summary>
    /// <typeparam name="T">The item type to delete</typeparam>
    /// <typeparam name="TKey">The type of the item key</typeparam>
    /// <typeparam name="TUser">The type to use to designate the user operating the actions</typeparam>
    public interface IManager<T, in TKey, in TUser> : IManager 
        where T : class, new()
    {
        /// <summary>
        /// Gets all items
        /// </summary>
        /// <returns>The collection of items</returns>
        Task<ManagerRequestResult<IEnumerable<T>>> GetAllAsync();

        /// <summary>
        /// Gets an item by its identifier
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>The item found or null</returns>
        Task<ManagerRequestResult<T>> GetByIdAsync(TKey id);

        /// <summary>
        /// Creates an item
        /// </summary>
        /// <param name="item">The item to create</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>True if succeeded. Otherwise, false</returns>
        Task<ManagerRequestResult> CreateAsync(T item, TUser user);

        /// <summary>
        /// Updates an item
        /// </summary>
        /// <param name="item">The item to update</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>True if succeeded. Otherwise, false</returns>
        Task<ManagerRequestResult> UpdateAsync(T item, TUser user);
    }
}
