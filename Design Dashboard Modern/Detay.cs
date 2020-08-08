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
    public partial class Detay : Form
    {
        int Move;
        int Mouse_X;
        int Mouse_Y;

        //Detay det;

        public string ad,sirket,tel;
        public Detay()
        {
            InitializeComponent();
            
        }

        private void Detay_Load(object sender, EventArgs e)
        {
            detLoad();
        }
        public void detLoad()
        {
            bunifuFlatButton1.Text = ad;
            buttonDashboard.Text = sirket;
            buttonProjeler.Text = tel;
            baslik.Text = sirket;
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

        private void Salir_Click(object sender, EventArgs e)
        {

            this.Hide();

            
        }

        private void MenuTop_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void MenuTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

    }
}
