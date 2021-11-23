using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace PPT_show
{
    public class MySql
    {
        public string host;
        public string database;
        public string username;
        public string password;
        public MySql(string host, string database, string username, string password)
        {

            this.host = host;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        public string[] Read(string sql)
        {
            string[] result = new string[3];
            string connstr = string.Format("data source={0};database={1};username={2};password={3};pooling=false;charset=utf8", this.host, this.database, this.username, this.password);
            Console.WriteLine(connstr);
            MySqlConnection conn = new MySqlConnection(connstr);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) // == this is the Read() method was called
            {
                result[0] = reader.GetString("username");
                result[1] = reader.GetString("password");

            }
            conn.Close();
            return result;

        }

    }
}
