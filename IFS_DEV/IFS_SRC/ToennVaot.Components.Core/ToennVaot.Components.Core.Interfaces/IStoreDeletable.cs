using ToennVaot.Components.Core.Models;
using ToennVaot.Components.Core.Models.Interfaces;

namespace ToennVaot.Components.Core.Interfaces;

/// <summary>
/// Interface defines the based store methods with model
/// </summary>
public interface IStoreDeletable<T, TUser> : IStore 
    where T : IDeletableRecord<TUser>
{
    /// <summary>
    /// Delete the item to the store
    /// </summary>
    /// <param name="item">The item to delete</param>
    /// <param name="user">The user makes the operation</param>
    /// <returns>The request result</returns>
    Task<StoreRequestResult> Delete(T item, TUser user);
}