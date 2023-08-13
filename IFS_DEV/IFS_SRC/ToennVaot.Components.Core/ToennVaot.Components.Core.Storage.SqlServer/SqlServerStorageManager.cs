using Microsoft.Data.SqlClient;
using ToennVaot.Components.Core.Interfaces;

namespace ToennVaot.Components.Core.Storage.SqlServer
{
    /// <summary>
    /// Defines the SQL Server storage manager
    /// </summary>
    public class SqlServerStorageManager : IStorageManager<SqlConnection, SqlTransaction>
    {
        /// <inheritdoc />
        public SqlConnection GetNewConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }

        /// <inheritdoc />
        public Tuple<SqlConnection, SqlTransaction> GetNewConnectionWithTransaction(string connectionString)
        {
            var connection = new SqlConnection(connectionString);
            var transaction = connection.BeginTransaction();

            return new Tuple<SqlConnection, SqlTransaction>(connection, transaction);
        }
    }
}