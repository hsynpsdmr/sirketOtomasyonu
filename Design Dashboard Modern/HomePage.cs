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
    public partial class HomePage : Form
    {
        DBConnect dbc = new DBConnect();
        EncDec ed=new EncDec();
        

        Dashboard d = new Dashboard();
        Projeler p = new Projeler();
        Musteriler m = new Musteriler();
        Calisanlar c = new Calisanlar();

        private string pass;

        public HomePage()
        {
            InitializeComponent();
         

            buttonDashboard.Hide();
            buttonProjeler.Hide();
            buttonMusteriler.Hide();
            buttonCalisanlar.Hide();
            
            buttonCikis.Hide();

            labelKullaniciAdi.Hide();
            textboxKullaniciAdi.Hide();
            labelParola.Hide();
            textboxParola.Hide();
            buttonGirisYap.Hide();

        }
        
       public void panelHide()
        {
            d.Hide();
            p.Hide();
            m.Hide();
            c.Hide();
        }

        private void matchPass()
        {
            dbc.dbConnect();
            MySqlCommand SelectCommand2 = new MySqlCommand("select password from morelmedyaotomasyon.users where username = '" + this.textboxKullaniciAdi.text + "';", dbc.connection);
            MySqlDataReader myReader2;
            dbc.connection.Open();
            myReader2 = SelectCommand2.ExecuteReader();
            if (myReader2.Read())
            {
                pass = myReader2.GetString(0);
               
            }
            dbc.connection.Close();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void kapat()
        {
            buttonProjeler.Hide();
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            labelKullaniciAdi.Show();
            textboxKullaniciAdi.Show();
            labelParola.Show();
            textboxParola.Show();
            buttonGirisYap.Show();

            textboxKullaniciAdi.Focus();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            string password = this.textboxParola.text;
            matchPass();
            ed.Encryption(password);
            if (pass.Equals(ed.finalData)){
                dbc.dbConnect();
                MySqlCommand SelectCommand1 = new MySqlCommand("select authority from morelmedyaotomasyon.users where username = '" + this.textboxKullaniciAdi.text + "';", dbc.connection);
                MySqlDataReader myReader1;
                dbc.connection.Open();
                myReader1 = SelectCommand1.ExecuteReader();
                if (myReader1.Read())
                {
                    var str = myReader1.GetInt32(0);
                    dbc.connection.Close();




                    MySqlCommand SelectCommand = new MySqlCommand("select * from morelmedyaotomasyon.users where username = '" + this.textboxKullaniciAdi.text + "' and password='" + ed.finalData + "';", dbc.connection);
                    MySqlDataReader myReader;
                    dbc.connection.Open();
                    myReader = SelectCommand.ExecuteReader();
                    if (str == 1)
                    {
                        MessageBox.Show("sen adminsin");
                        try
                        {
                            if (myReader.Read())
                            {
                                MessageBox.Show("username and password are matched", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buttonDashboard.Show();
                                buttonProjeler.Show();
                                buttonMusteriler.Show();
                                buttonCalisanlar.Show();
                                buttonGiris.Hide();
                                buttonCikis.Show();
                                labelKullaniciAdi.Hide();
                                textboxKullaniciAdi.Hide();
                                labelParola.Hide();
                                textboxParola.Hide();
                                buttonGirisYap.Hide();
                            }
                            else
                            {
                                MessageBox.Show("incorrect username and password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (str == 0)
                    {
                        MessageBox.Show("sen çalışansın");
                        try
                        {
                            if (myReader.Read())
                            {
                                MessageBox.Show("username and password are matched", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buttonDashboard.Show();
                                buttonGiris.Hide();
                                buttonCikis.Show();
                                labelKullaniciAdi.Hide();
                                textboxKullaniciAdi.Hide();
                                labelParola.Hide();
                                textboxParola.Hide();
                                buttonGirisYap.Hide();

                                buttonControl();
                            }
                            else
                            {
                                MessageBox.Show("incorrect username and password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    dbc.connection.Close();
                }
                dbc.connection.Close();
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            d.dashboardGauges();
            panelHide();
            baslik.Text = "DASHBOARD";
            d.Dock = DockStyle.Fill;
            d.TopLevel = false;
            d.FormBorderStyle = FormBorderStyle.None;
            PanelChart.Controls.Add(d);
            d.Show();
        }

        private void buttonProjeler_Click(object sender, EventArgs e)
        {
            panelHide();
            baslik.Text = "PROJELER";
            p.Dock = DockStyle.Fill;
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            PanelChart.Controls.Add(p);
            p.Show();
        }

        private void buttonMusteriler_Click(object sender, EventArgs e)
        {
            panelHide();
            baslik.Text = "MÜŞTERİLER";
            m.Dock = DockStyle.Fill;
            m.TopLevel = false;
            m.FormBorderStyle = FormBorderStyle.None;
            PanelChart.Controls.Add(m);
            m.Show();
        }

        private void buttonCalisanlar_Click(object sender, EventArgs e)
        {
            panelHide();
            baslik.Text = "ÇALIŞANLAR";
            c.Dock = DockStyle.Fill;
            c.TopLevel = false;
            c.FormBorderStyle = FormBorderStyle.None;
            PanelChart.Controls.Add(c);
            c.Show();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            panelHide();

            buttonDashboard.Hide();
            buttonProjeler.Hide();
            buttonMusteriler.Hide();
            buttonCalisanlar.Hide();

            buttonCikis.Hide();
            buttonGiris.Show();

            labelKullaniciAdi.Show();
            textboxKullaniciAdi.Show();
            labelParola.Show();
            textboxParola.Show();
            buttonGirisYap.Show();

            textboxKullaniciAdi.text = "";
            textboxParola.text = "";
        }
        private void buttonControl()
        {
            d.dButtonControl();
            p.pButtonControl();
            m.mButtonControl();
            c.cButtonControl();
        }
    }
}
