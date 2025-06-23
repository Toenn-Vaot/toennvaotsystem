using System.Data.Common;

namespace ToennVaot.Components.Core.Interfaces
{
    /// <summary>
    /// Defines the storage manager interface
    /// </summary>
    /// <typeparam name="T">The database connection provider type</typeparam>
    /// <typeparam name="TU">The database transaction provider type</typeparam>
    public interface IStorageManager<T, TU>
        where T : DbConnection, new()
        where TU : DbTransaction
    {
        /// <summary>
        /// Get a new database connection
        /// </summary>
        /// <returns>The database connection instance</returns>
        T GetConnection();

        /// <summary>
        /// Get a new database connection with an associated transaction
        /// </summary>
        /// <returns>The database connection instance and its attached database transaction</returns>
        Tuple<T, TU> GetConnectionWithTransaction();
    }
}