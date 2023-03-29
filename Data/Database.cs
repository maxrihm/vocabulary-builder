using MySql.Data.MySqlClient;

namespace Vocabulary
{
    public class Database
    {
        private readonly MySqlConnection connection;

        public Database(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void ExecuteNonQuery(string sql)
        {
            using (var cmd = new MySqlCommand(sql, connection))
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}