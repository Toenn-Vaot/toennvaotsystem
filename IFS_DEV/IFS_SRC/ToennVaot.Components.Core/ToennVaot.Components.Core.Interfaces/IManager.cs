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
    public interface IManager<T, in TKey, TUser> : IManager 
        where T : class, new()
    {
        /// <summary>
        /// Gets all items
        /// </summary>
        /// <returns>The collection of items</returns>
        Task<ManagerRequestResult<IEnumerable<T>>> GetAll();

        /// <summary>
        /// Gets an item by its identifier
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>The item found or null</returns>
        Task<ManagerRequestResult<T>> GetById(TKey id);

        /// <summary>
        /// Creates an item
        /// </summary>
        /// <param name="item">The item to create</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>True if succeed. Otherwise, false</returns>
        Task<ManagerRequestResult<bool>> Create(T item, TUser user);

        /// <summary>
        /// Updates an item
        /// </summary>
        /// <param name="item">The item to update</param>
        /// <param name="user">The user makes the operation</param>
        /// <returns>True if succeed. Otherwise, false</returns>
        Task<ManagerRequestResult<bool>> Update(T item, TUser user);
    }
}
