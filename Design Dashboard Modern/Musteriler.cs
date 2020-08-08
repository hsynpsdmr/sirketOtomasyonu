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
    public partial class Musteriler : Form
    {
        DBConnect dbc = new DBConnect();
        Detay det = new Detay();
        private int id;
        public Musteriler()
        {
            InitializeComponent();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            customersTable();
        }
        private void customersTable()
        {
            dbc.dbConnect();
            dbc.dataAdapter = new MySqlDataAdapter("select * from customers", dbc.connection);
            DataSet DS = new DataSet();
            dbc.dataAdapter.Fill(DS, "customers");
            dataGridView1.DataSource = DS.Tables["customers"];
        }

        public void mButtonControl()
        {
            textboxmAdSoyad.Hide();
            textboxmSirket.Hide();
            textboxmTelefon.Hide();
            buttonmAdd.Hide();
            buttonmDelete.Hide();
            buttonmUpdate.Hide();
        }

        private void buttonmAdd_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO morelmedyaotomasyon.customers (customername, customercompany, customerphone) VALUES('" + this.textboxmAdSoyad.text + "', '" + this.textboxmSirket.text + "','" + this.textboxmTelefon.text + "')";
            dbc.Insert(insert);
            customersTable();
        }

        private void buttonmDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİNMİSİNİZ?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "DELETE FROM morelmedyaotomasyon.customers WHERE customer_id='" + id + "'";
                dbc.Delete(delete);
                customersTable();
                MessageBox.Show("KAYIT SİLİNMİŞTİR");
            }
        }

        private void buttonmUpdate_Click(object sender, EventArgs e)
        {
            string update = "UPDATE morelmedyaotomasyon.customers SET customername='" + this.textboxmAdSoyad.text + "', customercompany='" + this.textboxmSirket.text + "', customerphone='" + this.textboxmTelefon.text + "' WHERE customer_id='" + id + "'";
            dbc.Update(update);
            customersTable();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            
            textboxmAdSoyad.text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textboxmSirket.text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textboxmTelefon.text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            det.ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            det.sirket = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            det.tel = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            det.detLoad();
            det.Show();
        }
    }
}
