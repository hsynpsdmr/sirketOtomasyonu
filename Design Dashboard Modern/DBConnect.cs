using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Design_Dashboard_Modern
{
    class DBConnect
    {
        public MySqlConnection connection;
        public MySqlDataAdapter dataAdapter;
        private string server;
        private string database;
        private string uid;
        private string password;


       public DataTable table;
        public DBConnect()
        {
            dbConnect();
        }

  
        public void dbConnect()
        {
            server = "localhost";
            database = "morelmedyaotomasyon";
            uid = "root";
            password = "1997";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }


        public void Insert(string insert)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(insert, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Update(string update)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = update;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Delete(string delete)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(delete, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        //public List<string>[] Select()
        //{
        //}

        //Count statement
        //public int Count()
        //{
        //}

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }

        public void searchData(string valueToSearch,string dataTable)
        {
            //string query = "SELECT * FROM '"+ dataTable + "' WHERE CONCAT('user_id ', 'username', 'password', 'autho') like '%" + valueToSearch + "%'";
            //MySqlCommand command = new MySqlCommand(query, connection);
            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //table = new DataTable();
            //adapter.Fill(table);
            ////dataGridView1.DataSource = table;
        }
    }
}
