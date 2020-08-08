namespace Design_Dashboard_Modern
{
    partial class Musteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriler));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.müsteriid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şirketi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textboxmTelefon = new Bunifu.Framework.UI.BunifuTextbox();
            this.textboxmSirket = new Bunifu.Framework.UI.BunifuTextbox();
            this.textboxmAdSoyad = new Bunifu.Framework.UI.BunifuTextbox();
            this.buttonmUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonmDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonmAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÜŞTERİLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.müsteriid,
            this.müşteriad,
            this.şirketi,
            this.telefon});
            this.dataGridView1.Location = new System.Drawing.Point(15, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 635);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // müsteriid
            // 
            this.müsteriid.DataPropertyName = "customer_id";
            this.müsteriid.HeaderText = "MÜŞTERİ_ ID";
            this.müsteriid.Name = "müsteriid";
            // 
            // müşteriad
            // 
            this.müşteriad.DataPropertyName = "customername";
            this.müşteriad.HeaderText = "MÜŞTERİ AD-SOYAD";
            this.müşteriad.Name = "müşteriad";
            // 
            // şirketi
            // 
            this.şirketi.DataPropertyName = "customercompany";
            this.şirketi.HeaderText = "MÜŞTERİNİN ŞİRKETİ";
            this.şirketi.Name = "şirketi";
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "customerphone";
            this.telefon.HeaderText = "MÜŞTERİNİN TELEFON";
            this.telefon.Name = "telefon";
            // 
            // buttonList
            // 
            this.buttonList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonList.BorderRadius = 0;
            this.buttonList.ButtonText = "LİSTELE";
            this.buttonList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonList.DisabledColor = System.Drawing.Color.Gray;
            this.buttonList.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonList.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonList.Iconimage")));
            this.buttonList.Iconimage_right = null;
            this.buttonList.Iconimage_right_Selected = null;
            this.buttonList.Iconimage_Selected = null;
            this.buttonList.IconMarginLeft = 0;
            this.buttonList.IconMarginRight = 0;
            this.buttonList.IconRightVisible = true;
            this.buttonList.IconRightZoom = 0D;
            this.buttonList.IconVisible = true;
            this.buttonList.IconZoom = 90D;
            this.buttonList.IsTab = false;
            this.buttonList.Location = new System.Drawing.Point(706, 499);
            this.buttonList.Name = "buttonList";
            this.buttonList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonList.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonList.selected = false;
            this.buttonList.Size = new System.Drawing.Size(241, 48);
            this.buttonList.TabIndex = 31;
            this.buttonList.Text = "LİSTELE";
            this.buttonList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonList.Textcolor = System.Drawing.Color.White;
            this.buttonList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // textboxmTelefon
            // 
            this.textboxmTelefon.BackColor = System.Drawing.Color.Silver;
            this.textboxmTelefon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxmTelefon.BackgroundImage")));
            this.textboxmTelefon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxmTelefon.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxmTelefon.Icon = ((System.Drawing.Image)(resources.GetObject("textboxmTelefon.Icon")));
            this.textboxmTelefon.Location = new System.Drawing.Point(706, 179);
            this.textboxmTelefon.Name = "textboxmTelefon";
            this.textboxmTelefon.Size = new System.Drawing.Size(241, 42);
            this.textboxmTelefon.TabIndex = 30;
            this.textboxmTelefon.text = "Müşterinin Telefonu";
            // 
            // textboxmSirket
            // 
            this.textboxmSirket.BackColor = System.Drawing.Color.Silver;
            this.textboxmSirket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxmSirket.BackgroundImage")));
            this.textboxmSirket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxmSirket.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxmSirket.Icon = ((System.Drawing.Image)(resources.GetObject("textboxmSirket.Icon")));
            this.textboxmSirket.Location = new System.Drawing.Point(706, 131);
            this.textboxmSirket.Name = "textboxmSirket";
            this.textboxmSirket.Size = new System.Drawing.Size(241, 42);
            this.textboxmSirket.TabIndex = 29;
            this.textboxmSirket.text = "Müşterinin Şirketi";
            // 
            // textboxmAdSoyad
            // 
            this.textboxmAdSoyad.BackColor = System.Drawing.Color.Silver;
            this.textboxmAdSoyad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxmAdSoyad.BackgroundImage")));
            this.textboxmAdSoyad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxmAdSoyad.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxmAdSoyad.Icon = ((System.Drawing.Image)(resources.GetObject("textboxmAdSoyad.Icon")));
            this.textboxmAdSoyad.Location = new System.Drawing.Point(706, 83);
            this.textboxmAdSoyad.Name = "textboxmAdSoyad";
            this.textboxmAdSoyad.Size = new System.Drawing.Size(241, 42);
            this.textboxmAdSoyad.TabIndex = 28;
            this.textboxmAdSoyad.text = "Müşteri Ad-Soyad";
            // 
            // buttonmUpdate
            // 
            this.buttonmUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonmUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonmUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonmUpdate.BorderRadius = 0;
            this.buttonmUpdate.ButtonText = "GÜNCELLE";
            this.buttonmUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.buttonmUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonmUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonmUpdate.Iconimage")));
            this.buttonmUpdate.Iconimage_right = null;
            this.buttonmUpdate.Iconimage_right_Selected = null;
            this.buttonmUpdate.Iconimage_Selected = null;
            this.buttonmUpdate.IconMarginLeft = 0;
            this.buttonmUpdate.IconMarginRight = 0;
            this.buttonmUpdate.IconRightVisible = true;
            this.buttonmUpdate.IconRightZoom = 0D;
            this.buttonmUpdate.IconVisible = true;
            this.buttonmUpdate.IconZoom = 90D;
            this.buttonmUpdate.IsTab = false;
            this.buttonmUpdate.Location = new System.Drawing.Point(706, 445);
            this.buttonmUpdate.Name = "buttonmUpdate";
            this.buttonmUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonmUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonmUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonmUpdate.selected = false;
            this.buttonmUpdate.Size = new System.Drawing.Size(241, 48);
            this.buttonmUpdate.TabIndex = 27;
            this.buttonmUpdate.Text = "GÜNCELLE";
            this.buttonmUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonmUpdate.Textcolor = System.Drawing.Color.White;
            this.buttonmUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmUpdate.Click += new System.EventHandler(this.buttonmUpdate_Click);
            // 
            // buttonmDelete
            // 
            this.buttonmDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonmDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonmDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonmDelete.BorderRadius = 0;
            this.buttonmDelete.ButtonText = "SİL";
            this.buttonmDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmDelete.DisabledColor = System.Drawing.Color.Gray;
            this.buttonmDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonmDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonmDelete.Iconimage")));
            this.buttonmDelete.Iconimage_right = null;
            this.buttonmDelete.Iconimage_right_Selected = null;
            this.buttonmDelete.Iconimage_Selected = null;
            this.buttonmDelete.IconMarginLeft = 0;
            this.buttonmDelete.IconMarginRight = 0;
            this.buttonmDelete.IconRightVisible = true;
            this.buttonmDelete.IconRightZoom = 0D;
            this.buttonmDelete.IconVisible = true;
            this.buttonmDelete.IconZoom = 90D;
            this.buttonmDelete.IsTab = false;
            this.buttonmDelete.Location = new System.Drawing.Point(706, 391);
            this.buttonmDelete.Name = "buttonmDelete";
            this.buttonmDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonmDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonmDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonmDelete.selected = false;
            this.buttonmDelete.Size = new System.Drawing.Size(241, 48);
            this.buttonmDelete.TabIndex = 26;
            this.buttonmDelete.Text = "SİL";
            this.buttonmDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonmDelete.Textcolor = System.Drawing.Color.White;
            this.buttonmDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmDelete.Click += new System.EventHandler(this.buttonmDelete_Click);
            // 
            // buttonmAdd
            // 
            this.buttonmAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonmAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonmAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonmAdd.BorderRadius = 0;
            this.buttonmAdd.ButtonText = "EKLE";
            this.buttonmAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmAdd.DisabledColor = System.Drawing.Color.Gray;
            this.buttonmAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonmAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonmAdd.Iconimage")));
            this.buttonmAdd.Iconimage_right = null;
            this.buttonmAdd.Iconimage_right_Selected = null;
            this.buttonmAdd.Iconimage_Selected = null;
            this.buttonmAdd.IconMarginLeft = 0;
            this.buttonmAdd.IconMarginRight = 0;
            this.buttonmAdd.IconRightVisible = true;
            this.buttonmAdd.IconRightZoom = 0D;
            this.buttonmAdd.IconVisible = true;
            this.buttonmAdd.IconZoom = 90D;
            this.buttonmAdd.IsTab = false;
            this.buttonmAdd.Location = new System.Drawing.Point(706, 337);
            this.buttonmAdd.Name = "buttonmAdd";
            this.buttonmAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonmAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonmAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonmAdd.selected = false;
            this.buttonmAdd.Size = new System.Drawing.Size(241, 48);
            this.buttonmAdd.TabIndex = 25;
            this.buttonmAdd.Text = "EKLE";
            this.buttonmAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonmAdd.Textcolor = System.Drawing.Color.White;
            this.buttonmAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmAdd.Click += new System.EventHandler(this.buttonmAdd_Click);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1047, 672);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.textboxmTelefon);
            this.Controls.Add(this.textboxmSirket);
            this.Controls.Add(this.textboxmAdSoyad);
            this.Controls.Add(this.buttonmUpdate);
            this.Controls.Add(this.buttonmDelete);
            this.Controls.Add(this.buttonmAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuTextbox textboxmTelefon;
        private Bunifu.Framework.UI.BunifuTextbox textboxmSirket;
        private Bunifu.Framework.UI.BunifuTextbox textboxmAdSoyad;
        private Bunifu.Framework.UI.BunifuFlatButton buttonmUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton buttonmDelete;
        private Bunifu.Framework.UI.BunifuFlatButton buttonmAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn müsteriid;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriad;
        private System.Windows.Forms.DataGridViewTextBoxColumn şirketi;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private Bunifu.Framework.UI.BunifuFlatButton buttonList;
    }
}