using MySql.Data.MySqlClient;
using ToennVaot.Components.Core.Storage.Interfaces;

namespace ToennVaot.Components.Core.Storage.Mysql
{
    public class MysqlStorageManager : IStorageManager<MySqlConnection, MySqlTransaction>
    {
        public MySqlConnection GetNewConnection(string connectionString)
        {
            return new MySqlConnection(connectionString);
        }

        public Tuple<MySqlConnection, MySqlTransaction> GetNewConnectionWithTransaction(string connectionString)
        {
            var connection = new MySqlConnection(connectionString);
            var transaction = connection.BeginTransaction();

            return new Tuple<MySqlConnection, MySqlTransaction>(connection, transaction);
        }
    }
}