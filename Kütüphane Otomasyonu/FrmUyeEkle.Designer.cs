namespace Kütüphane_Otomasyonu
{
    partial class FrmUyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUyeEkle));
            this.TxtBtnTc = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.CombomaxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBtnAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtBtnYas = new System.Windows.Forms.TextBox();
            this.TxtBtnAdres = new System.Windows.Forms.TextBox();
            this.TxtBtnEmail = new System.Windows.Forms.TextBox();
            this.TxtBtnOkunanKitapSayisi = new System.Windows.Forms.TextBox();
            this.BtnUyeEkle = new DevExpress.XtraEditors.SimpleButton();
            this.Btniptal = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // TxtBtnTc
            // 
            this.TxtBtnTc.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.TxtBtnTc.Location = new System.Drawing.Point(175, 48);
            this.TxtBtnTc.MaxLength = 11;
            this.TxtBtnTc.Name = "TxtBtnTc";
            this.TxtBtnTc.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnTc.TabIndex = 1;
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(175, 201);
            this.maskedTextBoxTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(151, 26);
            this.maskedTextBoxTelefon.TabIndex = 2;
            // 
            // CombomaxCinsiyet
            // 
            this.CombomaxCinsiyet.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.CombomaxCinsiyet.FormattingEnabled = true;
            this.CombomaxCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.CombomaxCinsiyet.Location = new System.Drawing.Point(175, 161);
            this.CombomaxCinsiyet.Name = "CombomaxCinsiyet";
            this.CombomaxCinsiyet.Size = new System.Drawing.Size(151, 27);
            this.CombomaxCinsiyet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(117, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "T.C :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(67, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adı Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(118, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yaş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(85, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(88, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(99, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(96, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "E-mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(9, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Oku. Kitap Sayısı :";
            // 
            // TxtBtnAdSoyad
            // 
            this.TxtBtnAdSoyad.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.TxtBtnAdSoyad.Location = new System.Drawing.Point(175, 86);
            this.TxtBtnAdSoyad.Name = "TxtBtnAdSoyad";
            this.TxtBtnAdSoyad.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnAdSoyad.TabIndex = 12;
            // 
            // TxtBtnYas
            // 
            this.TxtBtnYas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBtnYas.Location = new System.Drawing.Point(175, 124);
            this.TxtBtnYas.MaxLength = 3;
            this.TxtBtnYas.Name = "TxtBtnYas";
            this.TxtBtnYas.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnYas.TabIndex = 13;
            // 
            // TxtBtnAdres
            // 
            this.TxtBtnAdres.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBtnAdres.Location = new System.Drawing.Point(175, 239);
            this.TxtBtnAdres.Name = "TxtBtnAdres";
            this.TxtBtnAdres.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnAdres.TabIndex = 14;
            // 
            // TxtBtnEmail
            // 
            this.TxtBtnEmail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBtnEmail.Location = new System.Drawing.Point(175, 277);
            this.TxtBtnEmail.Name = "TxtBtnEmail";
            this.TxtBtnEmail.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnEmail.TabIndex = 15;
            // 
            // TxtBtnOkunanKitapSayisi
            // 
            this.TxtBtnOkunanKitapSayisi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBtnOkunanKitapSayisi.Location = new System.Drawing.Point(175, 315);
            this.TxtBtnOkunanKitapSayisi.Name = "TxtBtnOkunanKitapSayisi";
            this.TxtBtnOkunanKitapSayisi.Size = new System.Drawing.Size(151, 26);
            this.TxtBtnOkunanKitapSayisi.TabIndex = 16;
            this.TxtBtnOkunanKitapSayisi.Text = "0";
            this.TxtBtnOkunanKitapSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnUyeEkle
            // 
            this.BtnUyeEkle.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnUyeEkle.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUyeEkle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.BtnUyeEkle.Appearance.Options.UseBackColor = true;
            this.BtnUyeEkle.Appearance.Options.UseFont = true;
            this.BtnUyeEkle.Appearance.Options.UseForeColor = true;
            this.BtnUyeEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnUyeEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUyeEkle.ImageOptions.Image")));
            this.BtnUyeEkle.Location = new System.Drawing.Point(120, 388);
            this.BtnUyeEkle.Name = "BtnUyeEkle";
            this.BtnUyeEkle.Size = new System.Drawing.Size(124, 35);
            this.BtnUyeEkle.TabIndex = 17;
            this.BtnUyeEkle.Text = "Üye Ekle";
            this.BtnUyeEkle.Click += new System.EventHandler(this.BtnUyeEkle_Click);
            // 
            // Btniptal
            // 
            this.Btniptal.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btniptal.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btniptal.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Btniptal.Appearance.Options.UseBackColor = true;
            this.Btniptal.Appearance.Options.UseFont = true;
            this.Btniptal.Appearance.Options.UseForeColor = true;
            this.Btniptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.Btniptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btniptal.ImageOptions.Image")));
            this.Btniptal.Location = new System.Drawing.Point(250, 388);
            this.Btniptal.Name = "Btniptal";
            this.Btniptal.Size = new System.Drawing.Size(104, 35);
            this.Btniptal.TabIndex = 18;
            this.Btniptal.Text = "Geri";
            this.Btniptal.Click += new System.EventHandler(this.Btniptal_Click);
            // 
            // FrmUyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(377, 479);
            this.Controls.Add(this.Btniptal);
            this.Controls.Add(this.BtnUyeEkle);
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
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUyeEkle";
            this.Text = "Üye Ekleme ";
            this.Load += new System.EventHandler(this.FrmUyeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBtnTc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.ComboBox CombomaxCinsiyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBtnAdSoyad;
        private System.Windows.Forms.TextBox TxtBtnYas;
        private System.Windows.Forms.TextBox TxtBtnAdres;
        private System.Windows.Forms.TextBox TxtBtnEmail;
        private System.Windows.Forms.TextBox TxtBtnOkunanKitapSayisi;
        private DevExpress.XtraEditors.SimpleButton BtnUyeEkle;
        private DevExpress.XtraEditors.SimpleButton Btniptal;
    }
}