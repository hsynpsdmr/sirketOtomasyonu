namespace Design_Dashboard_Modern
{
    partial class HomePage
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.baslik = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonCikis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonCalisanlar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMusteriler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonGiris = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonProjeler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.labelParola = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelKullaniciAdi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonGirisYap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textboxParola = new Bunifu.Framework.UI.BunifuTextbox();
            this.textboxKullaniciAdi = new Bunifu.Framework.UI.BunifuTextbox();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.morelmedyaotomasyonDataSet = new Design_Dashboard_Modern.morelmedyaotomasyonDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Design_Dashboard_Modern.morelmedyaotomasyonDataSetTableAdapters.usersTableAdapter();
            this.morelmedyaotomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.PanelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.morelmedyaotomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.morelmedyaotomasyonDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.baslik);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1386, 80);
            this.MenuTop.TabIndex = 0;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1297, 24);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1261, 24);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1297, 24);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1333, 24);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.baslik, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.baslik, BunifuAnimatorNS.DecorationType.None);
            this.baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslik.ForeColor = System.Drawing.Color.White;
            this.baslik.Location = new System.Drawing.Point(82, 26);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(118, 20);
            this.baslik.TabIndex = 1;
            this.baslik.Text = "DASHBOARD";
            // 
            // MenuSidebar
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(34, 24);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 80);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 708);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.buttonCikis);
            this.Sidebar.Controls.Add(this.buttonCalisanlar);
            this.Sidebar.Controls.Add(this.buttonMusteriler);
            this.Sidebar.Controls.Add(this.buttonGiris);
            this.Sidebar.Controls.Add(this.buttonProjeler);
            this.Sidebar.Controls.Add(this.buttonDashboard);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(16, 24);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 672);
            this.Sidebar.TabIndex = 0;
            // 
            // buttonCikis
            // 
            this.buttonCikis.Activecolor = System.Drawing.Color.Transparent;
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCikis.BorderRadius = 0;
            this.buttonCikis.ButtonText = "       ÇIKIŞ YAP";
            this.buttonCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.buttonCikis, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.buttonCikis, BunifuAnimatorNS.DecorationType.None);
            this.buttonCikis.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCikis.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCikis.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.exit_64px;
            this.buttonCikis.Iconimage_right = null;
            this.buttonCikis.Iconimage_right_Selected = null;
            this.buttonCikis.Iconimage_Selected = null;
            this.buttonCikis.IconMarginLeft = 0;
            this.buttonCikis.IconMarginRight = 0;
            this.buttonCikis.IconRightVisible = true;
            this.buttonCikis.IconRightZoom = 0D;
            this.buttonCikis.IconVisible = true;
            this.buttonCikis.IconZoom = 90D;
            this.buttonCikis.IsTab = false;
            this.buttonCikis.Location = new System.Drawing.Point(9, 591);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonCikis.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttonCikis.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCikis.selected = false;
            this.buttonCikis.Size = new System.Drawing.Size(252, 51);
            this.buttonCikis.TabIndex = 14;
            this.buttonCikis.Text = "       ÇIKIŞ YAP";
            this.buttonCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCikis.Textcolor = System.Drawing.Color.LightGray;
            this.buttonCikis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonCalisanlar
            // 
            this.buttonCalisanlar.Activecolor = System.Drawing.Color.Transparent;
            this.buttonCalisanlar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCalisanlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCalisanlar.BorderRadius = 0;
            this.buttonCalisanlar.ButtonText = "      ÇALIŞANLAR";
            this.buttonCalisanlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.buttonCalisanlar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.buttonCalisanlar, BunifuAnimatorNS.DecorationType.None);
            this.buttonCalisanlar.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCalisanlar.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCalisanlar.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonCalisanlar.Iconimage")));
            this.buttonCalisanlar.Iconimage_right = null;
            this.buttonCalisanlar.Iconimage_right_Selected = null;
            this.buttonCalisanlar.Iconimage_Selected = null;
            this.buttonCalisanlar.IconMarginLeft = 0;
            this.buttonCalisanlar.IconMarginRight = 0;
            this.buttonCalisanlar.IconRightVisible = true;
            this.buttonCalisanlar.IconRightZoom = 0D;
            this.buttonCalisanlar.IconVisible = true;
            this.buttonCalisanlar.IconZoom = 50D;
            this.buttonCalisanlar.IsTab = false;
            this.buttonCalisanlar.Location = new System.Drawing.Point(9, 290);
            this.buttonCalisanlar.Name = "buttonCalisanlar";
            this.buttonCalisanlar.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonCalisanlar.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttonCalisanlar.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCalisanlar.selected = false;
            this.buttonCalisanlar.Size = new System.Drawing.Size(252, 51);
            this.buttonCalisanlar.TabIndex = 13;
            this.buttonCalisanlar.Text = "      ÇALIŞANLAR";
            this.buttonCalisanlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalisanlar.Textcolor = System.Drawing.Color.LightGray;
            this.buttonCalisanlar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonCalisanlar.Click += new System.EventHandler(this.buttonCalisanlar_Click);
            // 
            // buttonMusteriler
            // 
            this.buttonMusteriler.Activecolor = System.Drawing.Color.Transparent;
            this.buttonMusteriler.BackColor = System.Drawing.Color.Transparent;
            this.buttonMusteriler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMusteriler.BorderRadius = 0;
            this.buttonMusteriler.ButtonText = "      MÜŞTERİLER";
            this.buttonMusteriler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.buttonMusteriler, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.buttonMusteriler, BunifuAnimatorNS.DecorationType.None);
            this.buttonMusteriler.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMusteriler.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMusteriler.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonMusteriler.Iconimage")));
            this.buttonMusteriler.Iconimage_right = null;
            this.buttonMusteriler.Iconimage_right_Selected = null;
            this.buttonMusteriler.Iconimage_Selected = null;
            this.buttonMusteriler.IconMarginLeft = 0;
            this.buttonMusteriler.IconMarginRight = 0;
            this.buttonMusteriler.IconRightVisible = true;
            this.buttonMusteriler.IconRightZoom = 0D;
            this.buttonMusteriler.IconVisible = true;
            this.buttonMusteriler.IconZoom = 50D;
            this.buttonMusteriler.IsTab = false;
            this.buttonMusteriler.Location = new System.Drawing.Point(9, 233);
            this.buttonMusteriler.Name = "buttonMusteriler";
            this.buttonMusteriler.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonMusteriler.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttonMusteriler.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMusteriler.selected = false;
            this.buttonMusteriler.Size = new System.Drawing.Size(252, 51);
            this.buttonMusteriler.TabIndex = 12;
            this.buttonMusteriler.Text = "      MÜŞTERİLER";
            this.buttonMusteriler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMusteriler.Textcolor = System.Drawing.Color.LightGray;
            this.buttonMusteriler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonMusteriler.Click += new System.EventHandler(this.buttonMusteriler_Click);
            // 
            // buttonGiris
            // 
            this.buttonGiris.Activecolor = System.Drawing.Color.Transparent;
            this.buttonGiris.BackColor = System.Drawing.Color.Transparent;
            this.buttonGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGiris.BorderRadius = 0;
            this.buttonGiris.ButtonText = "      GİRİS YAP";
            this.buttonGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.buttonGiris, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.buttonGiris, BunifuAnimatorNS.DecorationType.None);
            this.buttonGiris.DisabledColor = System.Drawing.Color.Gray;
            this.buttonGiris.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonGiris.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.login_48px;
            this.buttonGiris.Iconimage_right = null;
            this.buttonGiris.Iconimage_right_Selected = null;
            this.buttonGiris.Iconimage_Selected = null;
            this.buttonGiris.IconMarginLeft = 0;
            this.buttonGiris.IconMarginRight = 0;
            this.buttonGiris.IconRightVisible = true;
            this.buttonGiris.IconRightZoom = 0D;
            this.buttonGiris.IconVisible = true;
            this.buttonGiris.IconZoom = 100D;
            this.buttonGiris.IsTab = false;
            this.buttonGiris.Location = new System.Drawing.Point(9, 534);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonGiris.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttonGiris.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonGiris.selected = false;
            this.buttonGiris.Size = new System.Drawing.Size(252, 51);
            this.buttonGiris.TabIndex = 11;
            this.buttonGiris.Text = "      GİRİS YAP";
            this.buttonGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGiris.Textcolor = System.Drawing.Color.LightGray;
            this.buttonGiris.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // buttonProjeler
            // 
            this.buttonProjeler.Activecolor = System.Drawing.Color.Transparent;
            this.buttonProjeler.BackColor = System.Drawing.Color.Transparent;
            this.buttonProjeler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProjeler.BorderRadius = 0;
            this.buttonProjeler.ButtonText = "      PROJELER";
            this.buttonProjeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.buttonProjeler, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.buttonProjeler, BunifuAnimatorNS.DecorationType.None);
            this.buttonProjeler.DisabledColor = System.Drawing.Color.Gray;
            this.buttonProjeler.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonProjeler.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonProjeler.Iconimage")));
            this.buttonProjeler.Iconimage_right = null;
            this.buttonProjeler.Iconimage_right_Selected = null;
            this.buttonProjeler.Iconimage_Selected = null;
            this.buttonProjeler.IconMarginLeft = 0;
            this.buttonProjeler.IconMarginRight = 0;
            this.buttonProjeler.IconRightVisible = true;
            this.buttonProjeler.IconRightZoom = 0D;
            this.buttonProjeler.IconVisible = true;
            this.buttonProjeler.IconZoom = 50D;
            this.buttonProjeler.IsTab = false;
            this.buttonProjeler.Location = new System.Drawing.Point(9, 176);
            this.buttonProjeler.Name = "buttonProjeler";
            this.buttonProjeler.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonProjeler.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttonProjeler.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonProjeler.selected = false;
            this.buttonProjeler.Size = new System.Drawing.Size(252, 51);
            this.buttonProjeler.TabIndex = 9;
            this.buttonProjeler.Text = "      PROJELER";
            this.buttonProjeler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjeler.Textcolor = System.Drawing.Color.LightGray;
            this.buttonProjeler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonProjeler.Click += new System.EventHandler(this.buttonProjeler_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Activecolor = System.Drawing.Color.Transparent;
            this.buttonDashboard.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDashboard.BorderRadius = 0;
            this.buttonDashboard.ButtonText = "      DASHBOARD";
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.buttonDashboard, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.buttonDashboard, BunifuAnimatorNS.DecorationType.None);
            this.buttonDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.buttonDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Iconimage")));
            this.buttonDashboard.Iconimage_right = null;
            this.buttonDashboard.Iconimage_right_Selected = null;
            this.buttonDashboard.Iconimage_Selected = null;
            this.buttonDashboard.IconMarginLeft = 0;
            this.buttonDashboard.IconMarginRight = 0;
            this.buttonDashboard.IconRightVisible = true;
            this.buttonDashboard.IconRightZoom = 0D;
            this.buttonDashboard.IconVisible = true;
            this.buttonDashboard.IconZoom = 50D;
            this.buttonDashboard.IsTab = false;
            this.buttonDashboard.Location = new System.Drawing.Point(9, 119);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonDashboard.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttonDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonDashboard.selected = false;
            this.buttonDashboard.Size = new System.Drawing.Size(252, 51);
            this.buttonDashboard.TabIndex = 8;
            this.buttonDashboard.Text = "      DASHBOARD";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Textcolor = System.Drawing.Color.LightGray;
            this.buttonDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(9, 112);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Design_Dashboard_Modern.Properties.Resources.c01e2326a1720a9ea4c86928d7a21414;
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.PanelChart);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1086, 708);
            this.Wrapper.TabIndex = 2;
            // 
            // PanelChart
            // 
            this.PanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.PanelChart.Controls.Add(this.labelParola);
            this.PanelChart.Controls.Add(this.labelKullaniciAdi);
            this.PanelChart.Controls.Add(this.buttonGirisYap);
            this.PanelChart.Controls.Add(this.textboxParola);
            this.PanelChart.Controls.Add(this.textboxKullaniciAdi);
            this.AnimacionSidebarBack.SetDecoration(this.PanelChart, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.PanelChart, BunifuAnimatorNS.DecorationType.None);
            this.PanelChart.Location = new System.Drawing.Point(16, 24);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(1047, 672);
            this.PanelChart.TabIndex = 0;
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.labelParola, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.labelParola, BunifuAnimatorNS.DecorationType.None);
            this.labelParola.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParola.ForeColor = System.Drawing.Color.White;
            this.labelParola.Location = new System.Drawing.Point(341, 246);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(61, 15);
            this.labelParola.TabIndex = 9;
            this.labelParola.Text = "Parola";
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.labelKullaniciAdi, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.labelKullaniciAdi, BunifuAnimatorNS.DecorationType.None);
            this.labelKullaniciAdi.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(342, 166);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(124, 15);
            this.labelKullaniciAdi.TabIndex = 8;
            this.labelKullaniciAdi.Text = "Kullanici Adi";
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGirisYap.BorderRadius = 0;
            this.buttonGirisYap.ButtonText = "GIRIS YAP";
            this.buttonGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.buttonGirisYap, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.buttonGirisYap, BunifuAnimatorNS.DecorationType.None);
            this.buttonGirisYap.DisabledColor = System.Drawing.Color.Gray;
            this.buttonGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonGirisYap.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonGirisYap.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonGirisYap.Iconimage")));
            this.buttonGirisYap.Iconimage_right = null;
            this.buttonGirisYap.Iconimage_right_Selected = null;
            this.buttonGirisYap.Iconimage_Selected = null;
            this.buttonGirisYap.IconMarginLeft = 0;
            this.buttonGirisYap.IconMarginRight = 0;
            this.buttonGirisYap.IconRightVisible = true;
            this.buttonGirisYap.IconRightZoom = 0D;
            this.buttonGirisYap.IconVisible = true;
            this.buttonGirisYap.IconZoom = 90D;
            this.buttonGirisYap.IsTab = false;
            this.buttonGirisYap.Location = new System.Drawing.Point(403, 326);
            this.buttonGirisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonGirisYap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonGirisYap.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonGirisYap.selected = false;
            this.buttonGirisYap.Size = new System.Drawing.Size(140, 36);
            this.buttonGirisYap.TabIndex = 3;
            this.buttonGirisYap.Text = "GIRIS YAP";
            this.buttonGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGirisYap.Textcolor = System.Drawing.Color.White;
            this.buttonGirisYap.TextFont = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // textboxParola
            // 
            this.textboxParola.BackColor = System.Drawing.Color.Silver;
            this.textboxParola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxParola.BackgroundImage")));
            this.textboxParola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimacionSidebarBack.SetDecoration(this.textboxParola, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.textboxParola, BunifuAnimatorNS.DecorationType.None);
            this.textboxParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.textboxParola.Icon = ((System.Drawing.Image)(resources.GetObject("textboxParola.Icon")));
            this.textboxParola.Location = new System.Drawing.Point(342, 264);
            this.textboxParola.Name = "textboxParola";
            this.textboxParola.Size = new System.Drawing.Size(250, 42);
            this.textboxParola.TabIndex = 2;
            this.textboxParola.text = "";
            // 
            // textboxKullaniciAdi
            // 
            this.textboxKullaniciAdi.BackColor = System.Drawing.Color.Silver;
            this.textboxKullaniciAdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxKullaniciAdi.BackgroundImage")));
            this.textboxKullaniciAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimacionSidebarBack.SetDecoration(this.textboxKullaniciAdi, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.textboxKullaniciAdi, BunifuAnimatorNS.DecorationType.None);
            this.textboxKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.textboxKullaniciAdi.Icon = ((System.Drawing.Image)(resources.GetObject("textboxKullaniciAdi.Icon")));
            this.textboxKullaniciAdi.Location = new System.Drawing.Point(342, 185);
            this.textboxKullaniciAdi.Name = "textboxKullaniciAdi";
            this.textboxKullaniciAdi.Size = new System.Drawing.Size(250, 42);
            this.textboxKullaniciAdi.TabIndex = 1;
            this.textboxKullaniciAdi.text = "";
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation1;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation2;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this.PanelChart;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // morelmedyaotomasyonDataSet
            // 
            this.morelmedyaotomasyonDataSet.DataSetName = "morelmedyaotomasyonDataSet";
            this.morelmedyaotomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.morelmedyaotomasyonDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // morelmedyaotomasyonDataSetBindingSource
            // 
            this.morelmedyaotomasyonDataSetBindingSource.DataSource = this.morelmedyaotomasyonDataSet;
            this.morelmedyaotomasyonDataSetBindingSource.Position = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.PanelChart.ResumeLayout(false);
            this.PanelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.morelmedyaotomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.morelmedyaotomasyonDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCikis;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCalisanlar;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMusteriler;
        private Bunifu.Framework.UI.BunifuFlatButton buttonGiris;
        private Bunifu.Framework.UI.BunifuFlatButton buttonProjeler;
        private Bunifu.Framework.UI.BunifuFlatButton buttonDashboard;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private System.Windows.Forms.Panel PanelChart;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton buttonGirisYap;
        private Bunifu.Framework.UI.BunifuTextbox textboxParola;
        private Bunifu.Framework.UI.BunifuTextbox textboxKullaniciAdi;
        private morelmedyaotomasyonDataSet morelmedyaotomasyonDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private morelmedyaotomasyonDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource morelmedyaotomasyonDataSetBindingSource;
        private Bunifu.Framework.UI.BunifuCustomLabel labelParola;
        private Bunifu.Framework.UI.BunifuCustomLabel labelKullaniciAdi;
    }
}

