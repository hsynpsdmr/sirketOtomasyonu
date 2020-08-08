namespace Design_Dashboard_Modern
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Authority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gaugeProje = new Bunifu.Framework.UI.BunifuGauge();
            this.gaugeMusteri = new Bunifu.Framework.UI.BunifuGauge();
            this.gaugeCalisan = new Bunifu.Framework.UI.BunifuGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gaugeKullanici = new Bunifu.Framework.UI.BunifuGauge();
            this.buttondAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttondDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttondUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textboxdUsername = new Bunifu.Framework.UI.BunifuTextbox();
            this.textboxdPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.textboxdAuthority = new Bunifu.Framework.UI.BunifuTextbox();
            this.buttonSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textboxdSearch = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.Username,
            this.Parola,
            this.Authority});
            this.dataGridView1.Location = new System.Drawing.Point(15, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 478);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // userid
            // 
            this.userid.DataPropertyName = "user_id";
            this.userid.HeaderText = "USER_ID";
            this.userid.Name = "userid";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "username";
            this.Username.HeaderText = "USERNAME";
            this.Username.Name = "Username";
            // 
            // Parola
            // 
            this.Parola.DataPropertyName = "password";
            this.Parola.HeaderText = "PASSWORD";
            this.Parola.Name = "Parola";
            // 
            // Authority
            // 
            this.Authority.DataPropertyName = "authority";
            this.Authority.HeaderText = "AUTHORITY";
            this.Authority.Name = "Authority";
            // 
            // gaugeProje
            // 
            this.gaugeProje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gaugeProje.BackgroundImage")));
            this.gaugeProje.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gaugeProje.ForeColor = System.Drawing.Color.White;
            this.gaugeProje.Location = new System.Drawing.Point(202, 56);
            this.gaugeProje.Margin = new System.Windows.Forms.Padding(6);
            this.gaugeProje.Name = "gaugeProje";
            this.gaugeProje.ProgressBgColor = System.Drawing.Color.Gray;
            this.gaugeProje.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.gaugeProje.ProgressColor2 = System.Drawing.Color.Tomato;
            this.gaugeProje.Size = new System.Drawing.Size(174, 117);
            this.gaugeProje.Suffix = "";
            this.gaugeProje.TabIndex = 10;
            this.gaugeProje.Thickness = 30;
            this.gaugeProje.Value = 0;
            // 
            // gaugeMusteri
            // 
            this.gaugeMusteri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gaugeMusteri.BackgroundImage")));
            this.gaugeMusteri.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gaugeMusteri.ForeColor = System.Drawing.Color.White;
            this.gaugeMusteri.Location = new System.Drawing.Point(388, 56);
            this.gaugeMusteri.Margin = new System.Windows.Forms.Padding(6);
            this.gaugeMusteri.Name = "gaugeMusteri";
            this.gaugeMusteri.ProgressBgColor = System.Drawing.Color.Gray;
            this.gaugeMusteri.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.gaugeMusteri.ProgressColor2 = System.Drawing.Color.Tomato;
            this.gaugeMusteri.Size = new System.Drawing.Size(174, 117);
            this.gaugeMusteri.Suffix = "";
            this.gaugeMusteri.TabIndex = 11;
            this.gaugeMusteri.Thickness = 30;
            this.gaugeMusteri.Value = 0;
            // 
            // gaugeCalisan
            // 
            this.gaugeCalisan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gaugeCalisan.BackgroundImage")));
            this.gaugeCalisan.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gaugeCalisan.ForeColor = System.Drawing.Color.White;
            this.gaugeCalisan.Location = new System.Drawing.Point(574, 56);
            this.gaugeCalisan.Margin = new System.Windows.Forms.Padding(6);
            this.gaugeCalisan.Name = "gaugeCalisan";
            this.gaugeCalisan.ProgressBgColor = System.Drawing.Color.Gray;
            this.gaugeCalisan.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.gaugeCalisan.ProgressColor2 = System.Drawing.Color.Tomato;
            this.gaugeCalisan.Size = new System.Drawing.Size(174, 117);
            this.gaugeCalisan.Suffix = "";
            this.gaugeCalisan.TabIndex = 12;
            this.gaugeCalisan.Thickness = 30;
            this.gaugeCalisan.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "PROJELER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(418, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "MÜŞTERİLER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(602, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "ÇALIŞANLAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "KULLANICILAR";
            // 
            // gaugeKullanici
            // 
            this.gaugeKullanici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gaugeKullanici.BackgroundImage")));
            this.gaugeKullanici.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gaugeKullanici.ForeColor = System.Drawing.Color.White;
            this.gaugeKullanici.Location = new System.Drawing.Point(16, 51);
            this.gaugeKullanici.Margin = new System.Windows.Forms.Padding(6);
            this.gaugeKullanici.Name = "gaugeKullanici";
            this.gaugeKullanici.ProgressBgColor = System.Drawing.Color.Gray;
            this.gaugeKullanici.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.gaugeKullanici.ProgressColor2 = System.Drawing.Color.Tomato;
            this.gaugeKullanici.Size = new System.Drawing.Size(174, 122);
            this.gaugeKullanici.Suffix = "";
            this.gaugeKullanici.TabIndex = 16;
            this.gaugeKullanici.Thickness = 30;
            this.gaugeKullanici.Value = 0;
            // 
            // buttondAdd
            // 
            this.buttondAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttondAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttondAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondAdd.BorderRadius = 0;
            this.buttondAdd.ButtonText = "EKLE";
            this.buttondAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondAdd.DisabledColor = System.Drawing.Color.Gray;
            this.buttondAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.buttondAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttondAdd.Iconimage")));
            this.buttondAdd.Iconimage_right = null;
            this.buttondAdd.Iconimage_right_Selected = null;
            this.buttondAdd.Iconimage_Selected = null;
            this.buttondAdd.IconMarginLeft = 0;
            this.buttondAdd.IconMarginRight = 0;
            this.buttondAdd.IconRightVisible = true;
            this.buttondAdd.IconRightZoom = 0D;
            this.buttondAdd.IconVisible = true;
            this.buttondAdd.IconZoom = 90D;
            this.buttondAdd.IsTab = false;
            this.buttondAdd.Location = new System.Drawing.Point(729, 450);
            this.buttondAdd.Name = "buttondAdd";
            this.buttondAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttondAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttondAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.buttondAdd.selected = false;
            this.buttondAdd.Size = new System.Drawing.Size(241, 48);
            this.buttondAdd.TabIndex = 18;
            this.buttondAdd.Text = "EKLE";
            this.buttondAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondAdd.Textcolor = System.Drawing.Color.White;
            this.buttondAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondAdd.Click += new System.EventHandler(this.buttondAdd_Click);
            // 
            // buttondDelete
            // 
            this.buttondDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttondDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttondDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondDelete.BorderRadius = 0;
            this.buttondDelete.ButtonText = "SİL";
            this.buttondDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondDelete.DisabledColor = System.Drawing.Color.Gray;
            this.buttondDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.buttondDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttondDelete.Iconimage")));
            this.buttondDelete.Iconimage_right = null;
            this.buttondDelete.Iconimage_right_Selected = null;
            this.buttondDelete.Iconimage_Selected = null;
            this.buttondDelete.IconMarginLeft = 0;
            this.buttondDelete.IconMarginRight = 0;
            this.buttondDelete.IconRightVisible = true;
            this.buttondDelete.IconRightZoom = 0D;
            this.buttondDelete.IconVisible = true;
            this.buttondDelete.IconZoom = 90D;
            this.buttondDelete.IsTab = false;
            this.buttondDelete.Location = new System.Drawing.Point(729, 504);
            this.buttondDelete.Name = "buttondDelete";
            this.buttondDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttondDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttondDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.buttondDelete.selected = false;
            this.buttondDelete.Size = new System.Drawing.Size(241, 48);
            this.buttondDelete.TabIndex = 19;
            this.buttondDelete.Text = "SİL";
            this.buttondDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondDelete.Textcolor = System.Drawing.Color.White;
            this.buttondDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondDelete.Click += new System.EventHandler(this.buttondDelete_Click);
            // 
            // buttondUpdate
            // 
            this.buttondUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttondUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttondUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondUpdate.BorderRadius = 0;
            this.buttondUpdate.ButtonText = "GÜNCELLE";
            this.buttondUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.buttondUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.buttondUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttondUpdate.Iconimage")));
            this.buttondUpdate.Iconimage_right = null;
            this.buttondUpdate.Iconimage_right_Selected = null;
            this.buttondUpdate.Iconimage_Selected = null;
            this.buttondUpdate.IconMarginLeft = 0;
            this.buttondUpdate.IconMarginRight = 0;
            this.buttondUpdate.IconRightVisible = true;
            this.buttondUpdate.IconRightZoom = 0D;
            this.buttondUpdate.IconVisible = true;
            this.buttondUpdate.IconZoom = 90D;
            this.buttondUpdate.IsTab = false;
            this.buttondUpdate.Location = new System.Drawing.Point(729, 558);
            this.buttondUpdate.Name = "buttondUpdate";
            this.buttondUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttondUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttondUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.buttondUpdate.selected = false;
            this.buttondUpdate.Size = new System.Drawing.Size(241, 48);
            this.buttondUpdate.TabIndex = 20;
            this.buttondUpdate.Text = "GÜNCELLE";
            this.buttondUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondUpdate.Textcolor = System.Drawing.Color.White;
            this.buttondUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondUpdate.Click += new System.EventHandler(this.buttondUpdate_Click);
            // 
            // textboxdUsername
            // 
            this.textboxdUsername.BackColor = System.Drawing.Color.Silver;
            this.textboxdUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxdUsername.BackgroundImage")));
            this.textboxdUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxdUsername.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxdUsername.Icon = ((System.Drawing.Image)(resources.GetObject("textboxdUsername.Icon")));
            this.textboxdUsername.Location = new System.Drawing.Point(729, 225);
            this.textboxdUsername.Name = "textboxdUsername";
            this.textboxdUsername.Size = new System.Drawing.Size(241, 42);
            this.textboxdUsername.TabIndex = 22;
            this.textboxdUsername.text = "Username";
            // 
            // textboxdPassword
            // 
            this.textboxdPassword.BackColor = System.Drawing.Color.Silver;
            this.textboxdPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxdPassword.BackgroundImage")));
            this.textboxdPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxdPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxdPassword.Icon = ((System.Drawing.Image)(resources.GetObject("textboxdPassword.Icon")));
            this.textboxdPassword.Location = new System.Drawing.Point(729, 273);
            this.textboxdPassword.Name = "textboxdPassword";
            this.textboxdPassword.Size = new System.Drawing.Size(241, 42);
            this.textboxdPassword.TabIndex = 23;
            this.textboxdPassword.text = "Password";
            // 
            // textboxdAuthority
            // 
            this.textboxdAuthority.BackColor = System.Drawing.Color.Silver;
            this.textboxdAuthority.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxdAuthority.BackgroundImage")));
            this.textboxdAuthority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxdAuthority.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxdAuthority.Icon = ((System.Drawing.Image)(resources.GetObject("textboxdAuthority.Icon")));
            this.textboxdAuthority.Location = new System.Drawing.Point(729, 321);
            this.textboxdAuthority.Name = "textboxdAuthority";
            this.textboxdAuthority.Size = new System.Drawing.Size(241, 42);
            this.textboxdAuthority.TabIndex = 24;
            this.textboxdAuthority.text = "Authority";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.BorderRadius = 0;
            this.buttonSearch.ButtonText = "SEARCH";
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Iconimage")));
            this.buttonSearch.Iconimage_right = null;
            this.buttonSearch.Iconimage_right_Selected = null;
            this.buttonSearch.Iconimage_Selected = null;
            this.buttonSearch.IconMarginLeft = 0;
            this.buttonSearch.IconMarginRight = 0;
            this.buttonSearch.IconRightVisible = true;
            this.buttonSearch.IconRightZoom = 0D;
            this.buttonSearch.IconVisible = true;
            this.buttonSearch.IconZoom = 90D;
            this.buttonSearch.IsTab = false;
            this.buttonSearch.Location = new System.Drawing.Point(794, 60);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSearch.selected = false;
            this.buttonSearch.Size = new System.Drawing.Size(241, 48);
            this.buttonSearch.TabIndex = 25;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Textcolor = System.Drawing.Color.White;
            this.buttonSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textboxdSearch
            // 
            this.textboxdSearch.BackColor = System.Drawing.Color.Silver;
            this.textboxdSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxdSearch.BackgroundImage")));
            this.textboxdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxdSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.textboxdSearch.Icon = ((System.Drawing.Image)(resources.GetObject("textboxdSearch.Icon")));
            this.textboxdSearch.Location = new System.Drawing.Point(794, 12);
            this.textboxdSearch.Name = "textboxdSearch";
            this.textboxdSearch.Size = new System.Drawing.Size(241, 42);
            this.textboxdSearch.TabIndex = 26;
            this.textboxdSearch.text = "Search...";
            this.textboxdSearch.KeyPress += new System.EventHandler(this.textboxdSearch_KeyPress);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1047, 672);
            this.Controls.Add(this.textboxdSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textboxdAuthority);
            this.Controls.Add(this.textboxdPassword);
            this.Controls.Add(this.textboxdUsername);
            this.Controls.Add(this.buttondUpdate);
            this.Controls.Add(this.buttondDelete);
            this.Controls.Add(this.buttondAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gaugeKullanici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gaugeCalisan);
            this.Controls.Add(this.gaugeMusteri);
            this.Controls.Add(this.gaugeProje);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authority;
        private Bunifu.Framework.UI.BunifuGauge gaugeProje;
        private Bunifu.Framework.UI.BunifuGauge gaugeMusteri;
        private Bunifu.Framework.UI.BunifuGauge gaugeCalisan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuGauge gaugeKullanici;
        private Bunifu.Framework.UI.BunifuFlatButton buttondAdd;
        private Bunifu.Framework.UI.BunifuFlatButton buttondDelete;
        private Bunifu.Framework.UI.BunifuFlatButton buttondUpdate;
        private Bunifu.Framework.UI.BunifuTextbox textboxdUsername;
        private Bunifu.Framework.UI.BunifuTextbox textboxdPassword;
        private Bunifu.Framework.UI.BunifuTextbox textboxdAuthority;
        private Bunifu.Framework.UI.BunifuFlatButton buttonSearch;
        private Bunifu.Framework.UI.BunifuTextbox textboxdSearch;
    }
}