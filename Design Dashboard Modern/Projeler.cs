using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design_Dashboard_Modern
{
    public partial class Projeler : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        DBConnect dbc = new DBConnect();
        private int id;
        public Projeler()
        {
            InitializeComponent();
            projectsTable();
        }

        private void Projeler_Load(object sender, EventArgs e)
        {

        }
        private void projectsTable()
        {
            dbc.dbConnect();
            mySqlDataAdapter = new MySqlDataAdapter("select * from projects", dbc.connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS, "projects");
            dataGridView1.DataSource = DS.Tables["projects"];
        }

        public void pButtonControl()
        {
            textboxpAdı.Hide();
            buttonpAdd.Hide();
            buttonpDelete.Hide();
            buttonpUpdate.Hide();
        }

        private void buttonpAdd_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO morelmedyaotomasyon.projects (projectname) VALUES('" + this.textboxpAdı.text + "')";
            dbc.Insert(insert);
            projectsTable();
        }

        private void buttonpDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİNMİSİNİZ?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "DELETE FROM morelmedyaotomasyon.projects WHERE project_id='" + id + "'";
                dbc.Delete(delete);
                projectsTable();
                MessageBox.Show("KAYIT SİLİNMİŞTİR");
            }
        }

        private void buttonpUpdate_Click(object sender, EventArgs e)
        {
            string update = "UPDATE morelmedyaotomasyon.projects SET projectname='" + this.textboxpAdı.text + "' WHERE project_id='" + id + "'";
            dbc.Update(update);
            projectsTable();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            textboxpAdı.text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
