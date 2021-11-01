
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Session2
{
    public class Connect
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=session2;");
        public MySqlConnection dbConnect() {
            return connection;
        }
        public void Open() {

            if (connection.State == System.Data.ConnectionState.Closed) {

                connection.Open();   
            
         }

        }

        public void Close()
        {

            if (connection.State == System.Data.ConnectionState.Open)
            {

                connection.Close();

            }

        }

    }
}
