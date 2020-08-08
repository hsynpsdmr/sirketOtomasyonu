using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class Dashboard : Form
    {
       
        DBConnect dbc = new DBConnect();
        EncDec ed = new EncDec();
        private int id;
        private string pass;
        public Dashboard()
        {
            InitializeComponent();

            usersTable();
            dataGridView1.Columns[2].Visible = false;
            
        }
        
        private void usersTable()
        {
            dbc.dbConnect();
            dbc.dataAdapter = new MySqlDataAdapter("select * from users", dbc.connection);
            DataSet DS = new DataSet();
            dbc.dataAdapter.Fill(DS, "users");
            dataGridView1.DataSource = DS.Tables["users"];
        }
        public void dashboardGauges()
        {
            dbc.dbConnect();
            MySqlCommand SelectCommand = new MySqlCommand("select count(*) from users;", dbc.connection);
            MySqlDataReader myReader;
            dbc.connection.Open();
            myReader = SelectCommand.ExecuteReader();
            while (myReader.Read())
            {
                var str = myReader.GetInt32(0);
                gaugeKullanici.Value = str;
            }
            dbc.connection.Close();

            MySqlCommand SelectCommand1 = new MySqlCommand("select count(*) from projects;", dbc.connection);
            MySqlDataReader myReader1;
            dbc.connection.Open();
            myReader1 = SelectCommand1.ExecuteReader();
            while (myReader1.Read())
            {
                var str = myReader1.GetInt32(0);
                gaugeProje.Value = str;
            }
            dbc.connection.Close();

            MySqlCommand SelectCommand2 = new MySqlCommand("select count(*) from customers;", dbc.connection);
            MySqlDataReader myReader2;
            dbc.connection.Open();
            myReader2 = SelectCommand2.ExecuteReader();
            while (myReader2.Read())
            {
                var str = myReader2.GetInt32(0);
                gaugeMusteri.Value = str;
            }
            dbc.connection.Close();

            MySqlCommand SelectCommand3 = new MySqlCommand("select count(*) from personnel;", dbc.connection);
            MySqlDataReader myReader3;
            dbc.connection.Open();
            myReader3 = SelectCommand3.ExecuteReader();
            while (myReader3.Read())
            {
                var str = myReader3.GetInt32(0);
                gaugeCalisan.Value = str;
            }
            dbc.connection.Close();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashboardGauges();
        }

        public void dButtonControl()
        {
            textboxdUsername.Hide();
            textboxdPassword.Hide();
            textboxdAuthority.Hide();
            buttondAdd.Hide();
            buttondDelete.Hide();
            buttondUpdate.Hide();
        }

        private void buttondAdd_Click(object sender, EventArgs e)
        {
            ed.Encryption(this.textboxdPassword.text);

            string insert = "INSERT INTO morelmedyaotomasyon.users (username, password, authority) VALUES('" + this.textboxdUsername.text + "', '" + ed.finalData + "','" + this.textboxdAuthority.text + "')";
            dbc.Insert(insert);
            usersTable();
            dashboardGauges();
        }

        private void buttondDelete_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİNMİSİNİZ?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string delete = "DELETE FROM morelmedyaotomasyon.users WHERE user_id='" + id + "'";
                    dbc.Delete(delete);
                    usersTable();
                    dashboardGauges();
                    MessageBox.Show("KAYIT SİLİNMİŞTİR");
                } 
        }

        private void buttondUpdate_Click(object sender, EventArgs e)
        {

            string update = "UPDATE morelmedyaotomasyon.users SET username='" + this.textboxdUsername.text + "', password='" + pass + "', authority='" + this.textboxdAuthority.text + "' WHERE user_id='" + id + "'";
            dbc.Update(update);
            usersTable();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            pass = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textboxdUsername.text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textboxdAuthority.text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string txt = this.textboxdSearch.text;
            string query = "SELECT * FROM users WHERE user_id like '%" + txt + "%' or username like '%" + txt + "%' or authority like '%" + txt + "%'";
            MySqlCommand command = new MySqlCommand(query, dbc.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }



        private void textboxdSearch_KeyPress(object sender, EventArgs e)
        {
            string txt = this.textboxdSearch.text;
            string query = "SELECT * FROM users WHERE user_id like '%"+txt+"%' or username like '%"+txt+"%' or authority like '%"+txt+"%'";
            MySqlCommand command = new MySqlCommand(query, dbc.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
