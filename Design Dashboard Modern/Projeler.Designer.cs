namespace Design_Dashboard_Modern
{
    partial class Projeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projeler));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonpAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonpDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonpUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textboxpAdı = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROJELER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projeid,
            this.proje});
            this.dataGridView1.Location = new System.Drawing.Point(15, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 635);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // projeid
            // 
            this.projeid.DataPropertyName = "project_id";
            this.projeid.HeaderText = "PROJE_ID";
            this.projeid.Name = "projeid";
            // 
            // proje
            // 
            this.proje.DataPropertyName = "projectname";
            this.proje.HeaderText = "PROJE ADI";
            this.proje.Name = "proje";
            // 
            // buttonpAdd
            // 
            this.buttonpAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonpAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpAdd.BorderRadius = 0;
            this.buttonpAdd.ButtonText = "EKLE";
            this.buttonpAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonpAdd.DisabledColor = System.Drawing.Color.Gray;
            this.buttonpAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonpAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonpAdd.Iconimage")));
            this.buttonpAdd.Iconimage_right = null;
            this.buttonpAdd.Iconimage_right_Selected = null;
            this.buttonpAdd.Iconimage_Selected = null;
            this.buttonpAdd.IconMarginLeft = 0;
            this.buttonpAdd.IconMarginRight = 0;
            this.buttonpAdd.IconRightVisible = true;
            this.buttonpAdd.IconRightZoom = 0D;
            this.buttonpAdd.IconVisible = true;
            this.buttonpAdd.IconZoom = 90D;
            this.buttonpAdd.IsTab = false;
            this.buttonpAdd.Location = new System.Drawing.Point(724, 331);
            this.buttonpAdd.Name = "buttonpAdd";
            this.buttonpAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonpAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonpAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonpAdd.selected = false;
            this.buttonpAdd.Size = new System.Drawing.Size(241, 48);
            this.buttonpAdd.TabIndex = 25;
            this.buttonpAdd.Text = "EKLE";
            this.buttonpAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonpAdd.Textcolor = System.Drawing.Color.White;
            this.buttonpAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpAdd.Click += new System.EventHandler(this.buttonpAdd_Click);
            // 
            // buttonpDelete
            // 
            this.buttonpDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonpDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonpDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpDelete.BorderRadius = 0;
            this.buttonpDelete.ButtonText = "SİL";
            this.buttonpDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonpDelete.DisabledColor = System.Drawing.Color.Gray;
            this.buttonpDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonpDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonpDelete.Iconimage")));
            this.buttonpDelete.Iconimage_right = null;
            this.buttonpDelete.Iconimage_right_Selected = null;
            this.buttonpDelete.Iconimage_Selected = null;
            this.buttonpDelete.IconMarginLeft = 0;
            this.buttonpDelete.IconMarginRight = 0;
            this.buttonpDelete.IconRightVisible = true;
            this.buttonpDelete.IconRightZoom = 0D;
            this.buttonpDelete.IconVisible = true;
            this.buttonpDelete.IconZoom = 90D;
            this.buttonpDelete.IsTab = false;
            this.buttonpDelete.Location = new System.Drawing.Point(724, 385);
            this.buttonpDelete.Name = "buttonpDelete";
            this.buttonpDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonpDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonpDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonpDelete.selected = false;
            this.buttonpDelete.Size = new System.Drawing.Size(241, 48);
            this.buttonpDelete.TabIndex = 26;
            this.buttonpDelete.Text = "SİL";
            this.buttonpDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonpDelete.Textcolor = System.Drawing.Color.White;
            this.buttonpDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpDelete.Click += new System.EventHandler(this.buttonpDelete_Click);
            // 
            // buttonpUpdate
            // 
            this.buttonpUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonpUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonpUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpUpdate.BorderRadius = 0;
            this.buttonpUpdate.ButtonText = "GÜNCELLE";
            this.buttonpUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonpUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.buttonpUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonpUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonpUpdate.Iconimage")));
            this.buttonpUpdate.Iconimage_right = null;
            this.buttonpUpdate.Iconimage_right_Selected = null;
            this.buttonpUpdate.Iconimage_Selected = null;
            this.buttonpUpdate.IconMarginLeft = 0;
            this.buttonpUpdate.IconMarginRight = 0;
            this.buttonpUpdate.IconRightVisible = true;
            this.buttonpUpdate.IconRightZoom = 0D;
            this.buttonpUpdate.IconVisible = true;
            this.buttonpUpdate.IconZoom = 90D;
            this.buttonpUpdate.IsTab = false;
            this.buttonpUpdate.Location = new System.Drawing.Point(724, 439);
            this.buttonpUpdate.Name = "buttonpUpdate";
            this.buttonpUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonpUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonpUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonpUpdate.selected = false;
            this.buttonpUpdate.Size = new System.Drawing.Size(241, 48);
            this.buttonpUpdate.TabIndex = 27;
            this.buttonpUpdate.Text = "GÜNCELLE";
            this.buttonpUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonpUpdate.Textcolor = System.Drawing.Color.White;
            this.buttonpUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpUpdate.Click += new System.EventHandler(this.buttonpUpdate_Click);
            // 
            // textboxpAdı
            // 
            this.textboxpAdı.BackColor = System.Drawing.Color.Silver;
            this.textboxpAdı.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxpAdı.BackgroundImage")));
            this.textboxpAdı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxpAdı.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxpAdı.Icon = ((System.Drawing.Image)(resources.GetObject("textboxpAdı.Icon")));
            this.textboxpAdı.Location = new System.Drawing.Point(724, 72);
            this.textboxpAdı.Name = "textboxpAdı";
            this.textboxpAdı.Size = new System.Drawing.Size(241, 42);
            this.textboxpAdı.TabIndex = 28;
            this.textboxpAdı.text = "Proje Adı";
            // 
            // Projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1047, 672);
            this.Controls.Add(this.textboxpAdı);
            this.Controls.Add(this.buttonpUpdate);
            this.Controls.Add(this.buttonpDelete);
            this.Controls.Add(this.buttonpAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Projeler";
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.Projeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn proje;
        private Bunifu.Framework.UI.BunifuFlatButton buttonpAdd;
        private Bunifu.Framework.UI.BunifuFlatButton buttonpDelete;
        private Bunifu.Framework.UI.BunifuFlatButton buttonpUpdate;
        private Bunifu.Framework.UI.BunifuTextbox textboxpAdı;
    }
}