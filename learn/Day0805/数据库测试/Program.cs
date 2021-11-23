using MySql.Data.MySqlClient;


namespace SqlClass {

    public class MySql {
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

        public void Read(string sql)
        {
            string connstr = string.Format("data source={0};database={1};username={2};password={3};pooling=false;charset=utf8", this.host, this.database, this.username, this.password);
            Console.WriteLine(connstr);
            MySqlConnection conn = new MySqlConnection(connstr);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(reader.GetInt32("userid") + "\t");
                if (reader.IsDBNull(1))
                {
                    Console.Write("空\t");
                }
                else
                {
                    Console.Write(reader.GetString("username") + "\t");
                }
                if (reader.IsDBNull(2))
                {
                    Console.Write("空\n");
                }
                else
                {
                    Console.Write(reader.GetString("password") + "\n");
                }
            }
            conn.Close();

        }

    }


        class MysqlTest {

            static void Main(string[] args)
            {
                MySql mysql = new MySql("127.0.0.1", "bim", "root", "root");
                string sql =  "select * from user";
                mysql.Read(sql);

            }
        }
        


    }



