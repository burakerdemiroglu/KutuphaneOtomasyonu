namespace Kütüphane_Otomasyonu
{
    partial class FrmUyeListeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUyeListeme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btniptal = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtBtnOkunanKitapSayisi = new System.Windows.Forms.TextBox();
            this.TxtBtnEmail = new System.Windows.Forms.TextBox();
            this.TxtBtnAdres = new System.Windows.Forms.TextBox();
            this.TxtBtnYas = new System.Windows.Forms.TextBox();
            this.TxtBtnAdSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CombomaxCinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtBtnTc = new System.Windows.Forms.TextBox();
            this.TxtTcAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Btniptal
            // 
            this.Btniptal.Appearance.BackColor = System.Drawing.Color.Snow;
            this.Btniptal.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btniptal.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btniptal.Appearance.Options.UseBackColor = true;
            this.Btniptal.Appearance.Options.UseFont = true;
            this.Btniptal.Appearance.Options.UseForeColor = true;
            this.Btniptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.Btniptal.ImageOptions.Image = global::Kütüphane_Otomasyonu.Properties.Resources.reset_16x16;
            this.Btniptal.Location = new System.Drawing.Point(210, 455);
            this.Btniptal.Name = "Btniptal";
            this.Btniptal.Size = new System.Drawing.Size(104, 35);
            this.Btniptal.TabIndex = 36;
            this.Btniptal.Text = "Geri";
            this.Btniptal.Click += new System.EventHandler(this.Btniptal_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.Appearance.Options.UseForeColor = true;
            this.BtnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnGuncelle.ImageOptions.Image = global::Kütüphane_Otomasyonu.Properties.Resources.convert_16x16;
            this.BtnGuncelle.Location = new System.Drawing.Point(143, 402);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(104, 35);
            this.BtnGuncelle.TabIndex = 35;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtBtnOkunanKitapSayisi
            // 
            this.TxtBtnOkunanKitapSayisi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBtnOkunanKitapSayisi.Location = new System.Drawing.Point(191, 338);
            this.TxtBtnOkunanKitapSayisi.Name = "TxtBtnOkunanKitapSayisi";
            this.TxtBtnOkunanKitapSayisi.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnOkunanKitapSayisi.TabIndex = 34;
            this.TxtBtnOkunanKitapSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBtnEmail
            // 
            this.TxtBtnEmail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBtnEmail.Location = new System.Drawing.Point(191, 300);
            this.TxtBtnEmail.Name = "TxtBtnEmail";
            this.TxtBtnEmail.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnEmail.TabIndex = 33;
            // 
            // TxtBtnAdres
            // 
            this.TxtBtnAdres.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBtnAdres.Location = new System.Drawing.Point(191, 262);
            this.TxtBtnAdres.Name = "TxtBtnAdres";
            this.TxtBtnAdres.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnAdres.TabIndex = 32;
            // 
            // TxtBtnYas
            // 
            this.TxtBtnYas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBtnYas.Location = new System.Drawing.Point(191, 147);
            this.TxtBtnYas.MaxLength = 3;
            this.TxtBtnYas.Name = "TxtBtnYas";
            this.TxtBtnYas.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnYas.TabIndex = 31;
            // 
            // TxtBtnAdSoyad
            // 
            this.TxtBtnAdSoyad.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.TxtBtnAdSoyad.Location = new System.Drawing.Point(191, 109);
            this.TxtBtnAdSoyad.Name = "TxtBtnAdSoyad";
            this.TxtBtnAdSoyad.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnAdSoyad.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(25, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Oku. Kitap Sayısı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(112, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "E-mail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(115, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Adres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(104, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(101, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cinsiyet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(134, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Yaş :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(83, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Adı Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(133, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "T.C :";
            // 
            // CombomaxCinsiyet
            // 
            this.CombomaxCinsiyet.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.CombomaxCinsiyet.FormattingEnabled = true;
            this.CombomaxCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.CombomaxCinsiyet.Location = new System.Drawing.Point(191, 184);
            this.CombomaxCinsiyet.Name = "CombomaxCinsiyet";
            this.CombomaxCinsiyet.Size = new System.Drawing.Size(151, 27);
            this.CombomaxCinsiyet.TabIndex = 21;
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(191, 224);
            this.maskedTextBoxTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(151, 26);
            this.maskedTextBoxTelefon.TabIndex = 20;
            // 
            // TxtBtnTc
            // 
            this.TxtBtnTc.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.TxtBtnTc.Location = new System.Drawing.Point(191, 71);
            this.TxtBtnTc.MaxLength = 11;
            this.TxtBtnTc.Name = "TxtBtnTc";
            this.TxtBtnTc.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnTc.TabIndex = 19;
            this.TxtBtnTc.TextChanged += new System.EventHandler(this.TxtBtnTc_TextChanged);
            // 
            // TxtTcAra
            // 
            this.TxtTcAra.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.TxtTcAra.Location = new System.Drawing.Point(597, 36);
            this.TxtTcAra.MaxLength = 11;
            this.TxtTcAra.Name = "TxtTcAra";
            this.TxtTcAra.Size = new System.Drawing.Size(151, 26);
            this.TxtTcAra.TabIndex = 37;
            this.TxtTcAra.TextChanged += new System.EventHandler(this.TxtTcAra_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(510, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "T.C Ara ";
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = System.Drawing.Color.Snow;
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.Appearance.Options.UseForeColor = true;
            this.BtnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(265, 402);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(104, 35);
            this.BtnSil.TabIndex = 39;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // FrmUyeListeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 502);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtTcAra);
            this.Controls.Add(this.Btniptal);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtBtnOkunanKitapSayisi);
            this.Controls.Add(this.TxtBtnEmail);
            this.Controls.Add(this.TxtBtnAdres);
            this.Controls.Add(this.TxtBtnYas);
            this.Controls.Add(this.TxtBtnAdSoyad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CombomaxCinsiyet);
            this.Controls.Add(this.maskedTextBoxTelefon);
            this.Controls.Add(this.TxtBtnTc);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUyeListeme";
            this.Text = "Üye Listeleme";
            this.Load += new System.EventHandler(this.FrmUyeListeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton Btniptal;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private System.Windows.Forms.TextBox TxtBtnOkunanKitapSayisi;
        private System.Windows.Forms.TextBox TxtBtnEmail;
        private System.Windows.Forms.TextBox TxtBtnAdres;
        private System.Windows.Forms.TextBox TxtBtnYas;
        private System.Windows.Forms.TextBox TxtBtnAdSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CombomaxCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.TextBox TxtBtnTc;
        private System.Windows.Forms.TextBox TxtTcAra;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
    }
}