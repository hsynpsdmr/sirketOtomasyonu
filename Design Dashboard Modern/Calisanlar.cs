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
    public partial class Calisanlar : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        DBConnect dbc = new DBConnect();
        Detay det = new Detay();
        private int id;
        public string ad;
        public Calisanlar()
        {
            InitializeComponent();

            personnelTable();
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {

        }

        private void personnelTable()
        {
            dbc.dbConnect();
            mySqlDataAdapter = new MySqlDataAdapter("select * from personnel", dbc.connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS, "personnel");
            dataGridView1.DataSource = DS.Tables["personnel"];
        }

        public void cButtonControl()
        {
            textboxcAdSoyad.Hide();
            textboxcGorev.Hide();
            textboxcTelefon.Hide();
            buttoncAdd.Hide();
            buttoncDelete.Hide();
            buttoncUpdate.Hide();
        }



        private void buttoncAdd_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO morelmedyaotomasyon.personnel (personnelname, personneltask, personnelphone) VALUES('" + this.textboxcAdSoyad.text + "', '" + this.textboxcGorev.text + "','" + this.textboxcTelefon.text + "')";
            dbc.Insert(insert);
            personnelTable();
        }

        private void buttoncDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİNMİSİNİZ?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "DELETE FROM morelmedyaotomasyon.personnel WHERE personnel_id='" + id + "'";
                dbc.Delete(delete);
                personnelTable();
                MessageBox.Show("KAYIT SİLİNMİŞTİR");
            }
        }

        private void buttoncUpdate_Click(object sender, EventArgs e)
        {
            string update = "UPDATE morelmedyaotomasyon.personnel SET personnelname='" + this.textboxcAdSoyad.text + "', personneltask='" + this.textboxcGorev.text + "', personnelphone='" + this.textboxcTelefon.text + "' WHERE personnel_id='" + id + "'";
            dbc.Update(update);
            personnelTable();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            textboxcAdSoyad.text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textboxcGorev.text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textboxcTelefon.text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            ad = textboxcAdSoyad.text;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            det.Show();
        }
    }
}
