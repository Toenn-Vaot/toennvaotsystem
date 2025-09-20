using ToennVaot.Components.Core.Models;
using ToennVaot.Components.Core.Models.Interfaces;

namespace ToennVaot.Components.Core.Interfaces;

/// <summary>
/// Interface defines the based manager methods to manage deletable items
/// </summary>
public interface IManagerDeletable<TU, TUser> : IStore 
    where TU : class
{
    /// <summary>
    /// Delete the item to the store
    /// </summary>
    /// <param name="item">The item to delete</param>
    /// <param name="user">The user makes the operation</param>
    /// <returns>The request result</returns>
    Task<ManagerRequestResult> Delete(IDeletableRecord<TUser> item, TUser user);
}