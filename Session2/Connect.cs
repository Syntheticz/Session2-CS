
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
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=Session2;");
        public MySqlConnection dbConnect() {
            return connection;
        }

        
    }
}
