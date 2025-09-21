using ToennVaot.Components.Core.Models;
using ToennVaot.Components.Core.Models.Interfaces;

namespace ToennVaot.Components.Core.Interfaces;

/// <summary>
/// Interface defines the based manager methods to manage deletable items
/// </summary>
/// <typeparam name="T">The item type to delete</typeparam>
/// <typeparam name="TUser">The type to use to designate the user operating the actions</typeparam>
public interface IManagerDeletable<in T, in TUser> : IStore 
    where T : class, IDeletableRecord<TUser>
{
    /// <summary>
    /// Delete the item to the store
    /// </summary>
    /// <param name="item">The item to delete</param>
    /// <param name="user">The user makes the operation</param>
    /// <returns>The request result</returns>
    Task<ManagerRequestResult> DeleteAsync(T item, TUser user);
}