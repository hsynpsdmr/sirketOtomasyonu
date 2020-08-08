namespace Design_Dashboard_Modern
{
    partial class Calisanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calisanlar));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.çalışanid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textboxcGorev = new Bunifu.Framework.UI.BunifuTextbox();
            this.textboxcAdSoyad = new Bunifu.Framework.UI.BunifuTextbox();
            this.textboxcTelefon = new Bunifu.Framework.UI.BunifuTextbox();
            this.buttoncUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttoncDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttoncAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonList = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÇALIŞANLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.çalışanid,
            this.adsoyad,
            this.görev,
            this.telefon});
            this.dataGridView1.Location = new System.Drawing.Point(15, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 635);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // çalışanid
            // 
            this.çalışanid.DataPropertyName = "personnel_id";
            this.çalışanid.HeaderText = "ÇALIŞAN_ID";
            this.çalışanid.Name = "çalışanid";
            // 
            // adsoyad
            // 
            this.adsoyad.DataPropertyName = "personnelname";
            this.adsoyad.HeaderText = "ÇALIŞAN AD-SOYAD";
            this.adsoyad.Name = "adsoyad";
            // 
            // görev
            // 
            this.görev.DataPropertyName = "personneltask";
            this.görev.HeaderText = "ÇALIŞANIN GÖREVİ";
            this.görev.Name = "görev";
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "personnelphone";
            this.telefon.HeaderText = "ÇALIŞAN TELEFON";
            this.telefon.Name = "telefon";
            // 
            // textboxcGorev
            // 
            this.textboxcGorev.BackColor = System.Drawing.Color.Silver;
            this.textboxcGorev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxcGorev.BackgroundImage")));
            this.textboxcGorev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxcGorev.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxcGorev.Icon = ((System.Drawing.Image)(resources.GetObject("textboxcGorev.Icon")));
            this.textboxcGorev.Location = new System.Drawing.Point(726, 117);
            this.textboxcGorev.Name = "textboxcGorev";
            this.textboxcGorev.Size = new System.Drawing.Size(241, 42);
            this.textboxcGorev.TabIndex = 30;
            this.textboxcGorev.text = "Çalışanın Görevi";
            // 
            // textboxcAdSoyad
            // 
            this.textboxcAdSoyad.BackColor = System.Drawing.Color.Silver;
            this.textboxcAdSoyad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxcAdSoyad.BackgroundImage")));
            this.textboxcAdSoyad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxcAdSoyad.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxcAdSoyad.Icon = ((System.Drawing.Image)(resources.GetObject("textboxcAdSoyad.Icon")));
            this.textboxcAdSoyad.Location = new System.Drawing.Point(726, 69);
            this.textboxcAdSoyad.Name = "textboxcAdSoyad";
            this.textboxcAdSoyad.Size = new System.Drawing.Size(241, 42);
            this.textboxcAdSoyad.TabIndex = 29;
            this.textboxcAdSoyad.text = "Çalışan Ad-Soyad";
            // 
            // textboxcTelefon
            // 
            this.textboxcTelefon.BackColor = System.Drawing.Color.Silver;
            this.textboxcTelefon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxcTelefon.BackgroundImage")));
            this.textboxcTelefon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxcTelefon.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxcTelefon.Icon = ((System.Drawing.Image)(resources.GetObject("textboxcTelefon.Icon")));
            this.textboxcTelefon.Location = new System.Drawing.Point(726, 165);
            this.textboxcTelefon.Name = "textboxcTelefon";
            this.textboxcTelefon.Size = new System.Drawing.Size(241, 42);
            this.textboxcTelefon.TabIndex = 28;
            this.textboxcTelefon.text = "Çalışan Telefon";
            // 
            // buttoncUpdate
            // 
            this.buttoncUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttoncUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttoncUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoncUpdate.BorderRadius = 0;
            this.buttoncUpdate.ButtonText = "GÜNCELLE";
            this.buttoncUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.buttoncUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.buttoncUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttoncUpdate.Iconimage")));
            this.buttoncUpdate.Iconimage_right = null;
            this.buttoncUpdate.Iconimage_right_Selected = null;
            this.buttoncUpdate.Iconimage_Selected = null;
            this.buttoncUpdate.IconMarginLeft = 0;
            this.buttoncUpdate.IconMarginRight = 0;
            this.buttoncUpdate.IconRightVisible = true;
            this.buttoncUpdate.IconRightZoom = 0D;
            this.buttoncUpdate.IconVisible = true;
            this.buttoncUpdate.IconZoom = 90D;
            this.buttoncUpdate.IsTab = false;
            this.buttoncUpdate.Location = new System.Drawing.Point(726, 418);
            this.buttoncUpdate.Name = "buttoncUpdate";
            this.buttoncUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttoncUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttoncUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.buttoncUpdate.selected = false;
            this.buttoncUpdate.Size = new System.Drawing.Size(241, 48);
            this.buttoncUpdate.TabIndex = 27;
            this.buttoncUpdate.Text = "GÜNCELLE";
            this.buttoncUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncUpdate.Textcolor = System.Drawing.Color.White;
            this.buttoncUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncUpdate.Click += new System.EventHandler(this.buttoncUpdate_Click);
            // 
            // buttoncDelete
            // 
            this.buttoncDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttoncDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttoncDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoncDelete.BorderRadius = 0;
            this.buttoncDelete.ButtonText = "SİL";
            this.buttoncDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncDelete.DisabledColor = System.Drawing.Color.Gray;
            this.buttoncDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.buttoncDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttoncDelete.Iconimage")));
            this.buttoncDelete.Iconimage_right = null;
            this.buttoncDelete.Iconimage_right_Selected = null;
            this.buttoncDelete.Iconimage_Selected = null;
            this.buttoncDelete.IconMarginLeft = 0;
            this.buttoncDelete.IconMarginRight = 0;
            this.buttoncDelete.IconRightVisible = true;
            this.buttoncDelete.IconRightZoom = 0D;
            this.buttoncDelete.IconVisible = true;
            this.buttoncDelete.IconZoom = 90D;
            this.buttoncDelete.IsTab = false;
            this.buttoncDelete.Location = new System.Drawing.Point(726, 364);
            this.buttoncDelete.Name = "buttoncDelete";
            this.buttoncDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttoncDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttoncDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.buttoncDelete.selected = false;
            this.buttoncDelete.Size = new System.Drawing.Size(241, 48);
            this.buttoncDelete.TabIndex = 26;
            this.buttoncDelete.Text = "SİL";
            this.buttoncDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncDelete.Textcolor = System.Drawing.Color.White;
            this.buttoncDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncDelete.Click += new System.EventHandler(this.buttoncDelete_Click);
            // 
            // buttoncAdd
            // 
            this.buttoncAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttoncAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttoncAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoncAdd.BorderRadius = 0;
            this.buttoncAdd.ButtonText = "EKLE";
            this.buttoncAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncAdd.DisabledColor = System.Drawing.Color.Gray;
            this.buttoncAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.buttoncAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttoncAdd.Iconimage")));
            this.buttoncAdd.Iconimage_right = null;
            this.buttoncAdd.Iconimage_right_Selected = null;
            this.buttoncAdd.Iconimage_Selected = null;
            this.buttoncAdd.IconMarginLeft = 0;
            this.buttoncAdd.IconMarginRight = 0;
            this.buttoncAdd.IconRightVisible = true;
            this.buttoncAdd.IconRightZoom = 0D;
            this.buttoncAdd.IconVisible = true;
            this.buttoncAdd.IconZoom = 90D;
            this.buttoncAdd.IsTab = false;
            this.buttoncAdd.Location = new System.Drawing.Point(726, 310);
            this.buttoncAdd.Name = "buttoncAdd";
            this.buttoncAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttoncAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttoncAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.buttoncAdd.selected = false;
            this.buttoncAdd.Size = new System.Drawing.Size(241, 48);
            this.buttoncAdd.TabIndex = 25;
            this.buttoncAdd.Text = "EKLE";
            this.buttoncAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncAdd.Textcolor = System.Drawing.Color.White;
            this.buttoncAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncAdd.Click += new System.EventHandler(this.buttoncAdd_Click);
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
            this.buttonList.Location = new System.Drawing.Point(726, 472);
            this.buttonList.Name = "buttonList";
            this.buttonList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonList.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonList.selected = false;
            this.buttonList.Size = new System.Drawing.Size(241, 48);
            this.buttonList.TabIndex = 32;
            this.buttonList.Text = "LİSTELE";
            this.buttonList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonList.Textcolor = System.Drawing.Color.White;
            this.buttonList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // Calisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1047, 672);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.textboxcGorev);
            this.Controls.Add(this.textboxcAdSoyad);
            this.Controls.Add(this.textboxcTelefon);
            this.Controls.Add(this.buttoncUpdate);
            this.Controls.Add(this.buttoncDelete);
            this.Controls.Add(this.buttoncAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calisanlar";
            this.Text = "Calisanlar";
            this.Load += new System.EventHandler(this.Calisanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuTextbox textboxcGorev;
        private Bunifu.Framework.UI.BunifuTextbox textboxcAdSoyad;
        private Bunifu.Framework.UI.BunifuTextbox textboxcTelefon;
        private Bunifu.Framework.UI.BunifuFlatButton buttoncUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton buttoncDelete;
        private Bunifu.Framework.UI.BunifuFlatButton buttoncAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn çalışanid;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn görev;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private Bunifu.Framework.UI.BunifuFlatButton buttonList;
    }
}