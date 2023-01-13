using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    public class Database
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=1234;database=vocabulary");

        public Database()
        {
            //connection.Open();
        }

        public void closeConnection()
        {
            connection.Close();
        }

        public void writeToDB(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }

    }
}
