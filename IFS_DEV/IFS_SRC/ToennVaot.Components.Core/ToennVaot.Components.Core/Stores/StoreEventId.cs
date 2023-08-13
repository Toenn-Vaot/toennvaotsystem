using Microsoft.Extensions.Logging;

namespace ToennVaot.Components.Core.Stores
{
    /// <summary>
    /// The store event identifiers class
    /// </summary>
    public static class StoreEventId
    {
        /// <summary>
        /// Event identifier when item not exists
        /// </summary>
        /// <typeparam name="T">The type of item</typeparam>
        /// <param name="message">The event message</param>
        /// <returns>The event identifier</returns>
        public static EventId ItemNotExistsEventId<T>(string message = null) { return new EventId(900010, message ?? $"{typeof(T).Name}' item not exists in storage"); }
        
        /// <summary>
        /// Event identifier when item not exists to update
        /// </summary>
        /// <typeparam name="T">The type of item</typeparam>
        /// <param name="message">The event message</param>
        /// <returns>The event identifier</returns>
        public static EventId ItemNotExistsToUpdateEventId<T>(string message = null) { return new EventId(900011, message ?? $"{typeof(T).Name}' item not exists in storage, update cancelled"); }

        /// <summary>
        /// Event identifier when item not exists to delete
        /// </summary>
        /// <typeparam name="T">The type of item</typeparam>
        /// <param name="message">The event message</param>
        /// <returns>The event identifier</returns>
        public static EventId ItemNotExistsToDeleteEventId<T>(string message = null) { return new EventId(900012, message ?? $"{typeof(T).Name}' item not exists in storage, deletion cancelled"); }
    }
}
