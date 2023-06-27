namespace Kütüphane_Otomasyonu
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.BtnUyeListeislem = new System.Windows.Forms.GroupBox();
            this.BtnUyeListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUyeEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnKitapListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKitapEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnEmanetKitapiade = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEmanetListeleme = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEmanetVerme = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnGrafik = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSiralama = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUyeListeislem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnUyeListeislem
            // 
            this.BtnUyeListeislem.BackColor = System.Drawing.Color.Transparent;
            this.BtnUyeListeislem.Controls.Add(this.BtnUyeListele);
            this.BtnUyeListeislem.Controls.Add(this.BtnUyeEkle);
            this.BtnUyeListeislem.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUyeListeislem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUyeListeislem.Location = new System.Drawing.Point(25, 22);
            this.BtnUyeListeislem.Name = "BtnUyeListeislem";
            this.BtnUyeListeislem.Size = new System.Drawing.Size(360, 172);
            this.BtnUyeListeislem.TabIndex = 0;
            this.BtnUyeListeislem.TabStop = false;
            this.BtnUyeListeislem.Text = "Üye İşlemleri";
            // 
            // BtnUyeListele
            // 
            this.BtnUyeListele.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnUyeListele.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUyeListele.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.BtnUyeListele.Appearance.Options.UseBackColor = true;
            this.BtnUyeListele.Appearance.Options.UseFont = true;
            this.BtnUyeListele.Appearance.Options.UseForeColor = true;
            this.BtnUyeListele.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnUyeListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUyeListele.ImageOptions.Image")));
            this.BtnUyeListele.Location = new System.Drawing.Point(38, 98);
            this.BtnUyeListele.Name = "BtnUyeListele";
            this.BtnUyeListele.Size = new System.Drawing.Size(279, 32);
            this.BtnUyeListele.TabIndex = 1;
            this.BtnUyeListele.Text = "Üye Listeleme İşlemleri";
            this.BtnUyeListele.Click += new System.EventHandler(this.BtnUyeListele_Click);
            // 
            // BtnUyeEkle
            // 
            this.BtnUyeEkle.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnUyeEkle.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUyeEkle.Appearance.Options.UseBackColor = true;
            this.BtnUyeEkle.Appearance.Options.UseFont = true;
            this.BtnUyeEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnUyeEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUyeEkle.ImageOptions.Image")));
            this.BtnUyeEkle.Location = new System.Drawing.Point(38, 34);
            this.BtnUyeEkle.Name = "BtnUyeEkle";
            this.BtnUyeEkle.Size = new System.Drawing.Size(279, 32);
            this.BtnUyeEkle.TabIndex = 0;
            this.BtnUyeEkle.Text = "Üye Ekleme İşlemleri";
            this.BtnUyeEkle.Click += new System.EventHandler(this.BtnUyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnKitapListele);
            this.groupBox2.Controls.Add(this.BtnKitapEkle);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(25, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // BtnKitapListele
            // 
            this.BtnKitapListele.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnKitapListele.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKitapListele.Appearance.Options.UseBackColor = true;
            this.BtnKitapListele.Appearance.Options.UseFont = true;
            this.BtnKitapListele.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnKitapListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKitapListele.ImageOptions.Image")));
            this.BtnKitapListele.Location = new System.Drawing.Point(38, 103);
            this.BtnKitapListele.Name = "BtnKitapListele";
            this.BtnKitapListele.Size = new System.Drawing.Size(279, 32);
            this.BtnKitapListele.TabIndex = 2;
            this.BtnKitapListele.Text = "Kitap Listeleme İşlemleri";
            this.BtnKitapListele.Click += new System.EventHandler(this.BtnKitapListele_Click);
            // 
            // BtnKitapEkle
            // 
            this.BtnKitapEkle.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnKitapEkle.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKitapEkle.Appearance.Options.UseBackColor = true;
            this.BtnKitapEkle.Appearance.Options.UseFont = true;
            this.BtnKitapEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnKitapEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKitapEkle.ImageOptions.Image")));
            this.BtnKitapEkle.Location = new System.Drawing.Point(38, 39);
            this.BtnKitapEkle.Name = "BtnKitapEkle";
            this.BtnKitapEkle.Size = new System.Drawing.Size(279, 32);
            this.BtnKitapEkle.TabIndex = 1;
            this.BtnKitapEkle.Text = "Kitap Ekleme İşlemleri";
            this.BtnKitapEkle.Click += new System.EventHandler(this.BtnKitapEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.BtnEmanetKitapiade);
            this.groupBox3.Controls.Add(this.BtnEmanetListeleme);
            this.groupBox3.Controls.Add(this.BtnEmanetVerme);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(428, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 172);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // BtnEmanetKitapiade
            // 
            this.BtnEmanetKitapiade.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnEmanetKitapiade.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEmanetKitapiade.Appearance.Options.UseBackColor = true;
            this.BtnEmanetKitapiade.Appearance.Options.UseFont = true;
            this.BtnEmanetKitapiade.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnEmanetKitapiade.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmanetKitapiade.ImageOptions.Image")));
            this.BtnEmanetKitapiade.Location = new System.Drawing.Point(41, 116);
            this.BtnEmanetKitapiade.Name = "BtnEmanetKitapiade";
            this.BtnEmanetKitapiade.Size = new System.Drawing.Size(279, 32);
            this.BtnEmanetKitapiade.TabIndex = 3;
            this.BtnEmanetKitapiade.Text = "Emanet Kitap İade İşlemleri";
            this.BtnEmanetKitapiade.Click += new System.EventHandler(this.BtnEmanetKitapiade_Click);
            // 
            // BtnEmanetListeleme
            // 
            this.BtnEmanetListeleme.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnEmanetListeleme.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEmanetListeleme.Appearance.Options.UseBackColor = true;
            this.BtnEmanetListeleme.Appearance.Options.UseFont = true;
            this.BtnEmanetListeleme.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnEmanetListeleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmanetListeleme.ImageOptions.Image")));
            this.BtnEmanetListeleme.Location = new System.Drawing.Point(41, 71);
            this.BtnEmanetListeleme.Name = "BtnEmanetListeleme";
            this.BtnEmanetListeleme.Size = new System.Drawing.Size(279, 32);
            this.BtnEmanetListeleme.TabIndex = 2;
            this.BtnEmanetListeleme.Text = "Emanet Listeleme İşlemleri";
            this.BtnEmanetListeleme.Click += new System.EventHandler(this.BtnEmanetListeleme_Click);
            // 
            // BtnEmanetVerme
            // 
            this.BtnEmanetVerme.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnEmanetVerme.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEmanetVerme.Appearance.Options.UseBackColor = true;
            this.BtnEmanetVerme.Appearance.Options.UseFont = true;
            this.BtnEmanetVerme.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnEmanetVerme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmanetVerme.ImageOptions.Image")));
            this.BtnEmanetVerme.Location = new System.Drawing.Point(41, 26);
            this.BtnEmanetVerme.Name = "BtnEmanetVerme";
            this.BtnEmanetVerme.Size = new System.Drawing.Size(279, 32);
            this.BtnEmanetVerme.TabIndex = 1;
            this.BtnEmanetVerme.Text = "Emanet Kitap Verme İşlemleri";
            this.BtnEmanetVerme.Click += new System.EventHandler(this.BtnEmanetVerme_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.BtnGrafik);
            this.groupBox4.Controls.Add(this.BtnSiralama);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(428, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 172);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafiklerler";
            // 
            // BtnGrafik
            // 
            this.BtnGrafik.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnGrafik.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGrafik.Appearance.Options.UseBackColor = true;
            this.BtnGrafik.Appearance.Options.UseFont = true;
            this.BtnGrafik.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnGrafik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGrafik.ImageOptions.Image")));
            this.BtnGrafik.Location = new System.Drawing.Point(41, 103);
            this.BtnGrafik.Name = "BtnGrafik";
            this.BtnGrafik.Size = new System.Drawing.Size(279, 32);
            this.BtnGrafik.TabIndex = 3;
            this.BtnGrafik.Text = "Grafikler";
            this.BtnGrafik.Click += new System.EventHandler(this.BtnGrafik_Click);
            // 
            // BtnSiralama
            // 
            this.BtnSiralama.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnSiralama.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSiralama.Appearance.Options.UseBackColor = true;
            this.BtnSiralama.Appearance.Options.UseFont = true;
            this.BtnSiralama.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnSiralama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSiralama.ImageOptions.Image")));
            this.BtnSiralama.Location = new System.Drawing.Point(41, 39);
            this.BtnSiralama.Name = "BtnSiralama";
            this.BtnSiralama.Size = new System.Drawing.Size(279, 32);
            this.BtnSiralama.TabIndex = 2;
            this.BtnSiralama.Text = "Sıralama";
            this.BtnSiralama.Click += new System.EventHandler(this.BtnSiralama_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 435);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnUyeListeislem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.BtnUyeListeislem.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BtnUyeListeislem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton BtnUyeListele;
        private DevExpress.XtraEditors.SimpleButton BtnUyeEkle;
        private DevExpress.XtraEditors.SimpleButton BtnKitapListele;
        private DevExpress.XtraEditors.SimpleButton BtnKitapEkle;
        private DevExpress.XtraEditors.SimpleButton BtnEmanetKitapiade;
        private DevExpress.XtraEditors.SimpleButton BtnEmanetListeleme;
        private DevExpress.XtraEditors.SimpleButton BtnEmanetVerme;
        private DevExpress.XtraEditors.SimpleButton BtnGrafik;
        private DevExpress.XtraEditors.SimpleButton BtnSiralama;
    }
}

