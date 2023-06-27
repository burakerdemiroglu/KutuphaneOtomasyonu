namespace Kütüphane_Otomasyonu
{
    partial class FrmEmanetKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmanetKitap));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrupUyeBilgi = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYas = new System.Windows.Forms.TextBox();
            this.TxtBtnAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtBtnTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpKitapBilgileri = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSayfaSayisi = new System.Windows.Forms.TextBox();
            this.DtpiadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBoxYayinevi = new System.Windows.Forms.TextBox();
            this.textBoxYazari = new System.Windows.Forms.TextBox();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.textBoxBarkodNo = new System.Windows.Forms.TextBox();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTeslimEt = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.LblKayıtlıKitapSayisi = new System.Windows.Forms.Label();
            this.LblKitapSayisi = new System.Windows.Forms.Label();
            this.TxtKitapSayi = new System.Windows.Forms.TextBox();
            this.txtKayıtlıKitap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrupUyeBilgi.SuspendLayout();
            this.GrpKitapBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 520);
            this.dataGridView1.TabIndex = 0;
            // 
            // GrupUyeBilgi
            // 
            this.GrupUyeBilgi.Controls.Add(this.maskedTextBoxTelefon);
            this.GrupUyeBilgi.Controls.Add(this.label5);
            this.GrupUyeBilgi.Controls.Add(this.label4);
            this.GrupUyeBilgi.Controls.Add(this.label3);
            this.GrupUyeBilgi.Controls.Add(this.textBoxYas);
            this.GrupUyeBilgi.Controls.Add(this.TxtBtnAdSoyad);
            this.GrupUyeBilgi.Controls.Add(this.TxtBtnTc);
            this.GrupUyeBilgi.Controls.Add(this.label2);
            this.GrupUyeBilgi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrupUyeBilgi.Location = new System.Drawing.Point(12, 25);
            this.GrupUyeBilgi.Name = "GrupUyeBilgi";
            this.GrupUyeBilgi.Size = new System.Drawing.Size(319, 199);
            this.GrupUyeBilgi.TabIndex = 1;
            this.GrupUyeBilgi.TabStop = false;
            this.GrupUyeBilgi.Text = "Üye Bilgileri";
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(119, 149);
            this.maskedTextBoxTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(194, 26);
            this.maskedTextBoxTelefon.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(36, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(63, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Yaş :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ad Soyad :";
            // 
            // textBoxYas
            // 
            this.textBoxYas.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxYas.Location = new System.Drawing.Point(119, 112);
            this.textBoxYas.MaxLength = 11;
            this.textBoxYas.Name = "textBoxYas";
            this.textBoxYas.Size = new System.Drawing.Size(194, 26);
            this.textBoxYas.TabIndex = 28;
            // 
            // TxtBtnAdSoyad
            // 
            this.TxtBtnAdSoyad.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.TxtBtnAdSoyad.Location = new System.Drawing.Point(119, 75);
            this.TxtBtnAdSoyad.MaxLength = 11;
            this.TxtBtnAdSoyad.Name = "TxtBtnAdSoyad";
            this.TxtBtnAdSoyad.Size = new System.Drawing.Size(194, 26);
            this.TxtBtnAdSoyad.TabIndex = 26;
            // 
            // TxtBtnTc
            // 
            this.TxtBtnTc.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.TxtBtnTc.Location = new System.Drawing.Point(119, 38);
            this.TxtBtnTc.MaxLength = 11;
            this.TxtBtnTc.Name = "TxtBtnTc";
            this.TxtBtnTc.Size = new System.Drawing.Size(194, 26);
            this.TxtBtnTc.TabIndex = 24;
            this.TxtBtnTc.TextChanged += new System.EventHandler(this.TxtBtnTc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(31, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "TC Ara :";
            // 
            // GrpKitapBilgileri
            // 
            this.GrpKitapBilgileri.Controls.Add(this.label13);
            this.GrpKitapBilgileri.Controls.Add(this.label12);
            this.GrpKitapBilgileri.Controls.Add(this.label10);
            this.GrpKitapBilgileri.Controls.Add(this.label9);
            this.GrpKitapBilgileri.Controls.Add(this.label8);
            this.GrpKitapBilgileri.Controls.Add(this.label7);
            this.GrpKitapBilgileri.Controls.Add(this.label6);
            this.GrpKitapBilgileri.Controls.Add(this.textBoxSayfaSayisi);
            this.GrpKitapBilgileri.Controls.Add(this.DtpiadeTarihi);
            this.GrpKitapBilgileri.Controls.Add(this.DtpTeslimTarihi);
            this.GrpKitapBilgileri.Controls.Add(this.textBoxYayinevi);
            this.GrpKitapBilgileri.Controls.Add(this.textBoxYazari);
            this.GrpKitapBilgileri.Controls.Add(this.textBoxKitapAdi);
            this.GrpKitapBilgileri.Controls.Add(this.textBoxBarkodNo);
            this.GrpKitapBilgileri.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpKitapBilgileri.Location = new System.Drawing.Point(12, 230);
            this.GrpKitapBilgileri.Name = "GrpKitapBilgileri";
            this.GrpKitapBilgileri.Size = new System.Drawing.Size(319, 361);
            this.GrpKitapBilgileri.TabIndex = 2;
            this.GrpKitapBilgileri.TabStop = false;
            this.GrpKitapBilgileri.Text = "Kitap Bilgileri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(9, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 19);
            this.label13.TabIndex = 51;
            this.label13.Text = "İade Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(9, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 50;
            this.label12.Text = "Teslim Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(4, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 19);
            this.label10.TabIndex = 48;
            this.label10.Text = "Sayfa Sayısı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(34, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 47;
            this.label9.Text = "Yayınevi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(45, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "Yazarı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(24, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Kitap Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(17, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Barkod No :";
            // 
            // textBoxSayfaSayisi
            // 
            this.textBoxSayfaSayisi.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxSayfaSayisi.Location = new System.Drawing.Point(119, 200);
            this.textBoxSayfaSayisi.MaxLength = 11;
            this.textBoxSayfaSayisi.Name = "textBoxSayfaSayisi";
            this.textBoxSayfaSayisi.Size = new System.Drawing.Size(194, 26);
            this.textBoxSayfaSayisi.TabIndex = 42;
            // 
            // DtpiadeTarihi
            // 
            this.DtpiadeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpiadeTarihi.Location = new System.Drawing.Point(119, 295);
            this.DtpiadeTarihi.Name = "DtpiadeTarihi";
            this.DtpiadeTarihi.Size = new System.Drawing.Size(194, 30);
            this.DtpiadeTarihi.TabIndex = 40;
            // 
            // DtpTeslimTarihi
            // 
            this.DtpTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTeslimTarihi.Location = new System.Drawing.Point(119, 245);
            this.DtpTeslimTarihi.Name = "DtpTeslimTarihi";
            this.DtpTeslimTarihi.Size = new System.Drawing.Size(194, 30);
            this.DtpTeslimTarihi.TabIndex = 39;
            // 
            // textBoxYayinevi
            // 
            this.textBoxYayinevi.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxYayinevi.Location = new System.Drawing.Point(119, 159);
            this.textBoxYayinevi.MaxLength = 11;
            this.textBoxYayinevi.Name = "textBoxYayinevi";
            this.textBoxYayinevi.Size = new System.Drawing.Size(194, 26);
            this.textBoxYayinevi.TabIndex = 38;
            // 
            // textBoxYazari
            // 
            this.textBoxYazari.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxYazari.Location = new System.Drawing.Point(119, 121);
            this.textBoxYazari.MaxLength = 11;
            this.textBoxYazari.Name = "textBoxYazari";
            this.textBoxYazari.Size = new System.Drawing.Size(194, 26);
            this.textBoxYazari.TabIndex = 36;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxKitapAdi.Location = new System.Drawing.Point(119, 83);
            this.textBoxKitapAdi.MaxLength = 11;
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(194, 26);
            this.textBoxKitapAdi.TabIndex = 34;
            // 
            // textBoxBarkodNo
            // 
            this.textBoxBarkodNo.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxBarkodNo.Location = new System.Drawing.Point(119, 45);
            this.textBoxBarkodNo.MaxLength = 11;
            this.textBoxBarkodNo.Name = "textBoxBarkodNo";
            this.textBoxBarkodNo.Size = new System.Drawing.Size(194, 26);
            this.textBoxBarkodNo.TabIndex = 32;
            this.textBoxBarkodNo.TextChanged += new System.EventHandler(this.textBoxBarkodNo_TextChanged);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.Appearance.Options.UseForeColor = true;
            this.BtnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(967, 296);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(100, 35);
            this.BtnSil.TabIndex = 41;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnTeslimEt
            // 
            this.BtnTeslimEt.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnTeslimEt.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTeslimEt.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnTeslimEt.Appearance.Options.UseBackColor = true;
            this.BtnTeslimEt.Appearance.Options.UseFont = true;
            this.BtnTeslimEt.Appearance.Options.UseForeColor = true;
            this.BtnTeslimEt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnTeslimEt.ImageOptions.Image = global::Kütüphane_Otomasyonu.Properties.Resources.open2_16x16;
            this.BtnTeslimEt.Location = new System.Drawing.Point(967, 235);
            this.BtnTeslimEt.Name = "BtnTeslimEt";
            this.BtnTeslimEt.Size = new System.Drawing.Size(100, 35);
            this.BtnTeslimEt.TabIndex = 40;
            this.BtnTeslimEt.Text = "Teslim Et";
            this.BtnTeslimEt.Click += new System.EventHandler(this.BtnTeslimEt_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnGeri.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeri.Appearance.Options.UseBackColor = true;
            this.BtnGeri.Appearance.Options.UseFont = true;
            this.BtnGeri.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnGeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGeri.ImageOptions.Image")));
            this.BtnGeri.Location = new System.Drawing.Point(967, 357);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(100, 35);
            this.BtnGeri.TabIndex = 22;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.Appearance.Options.UseBackColor = true;
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(967, 174);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(100, 35);
            this.BtnEkle.TabIndex = 21;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // LblKayıtlıKitapSayisi
            // 
            this.LblKayıtlıKitapSayisi.AutoSize = true;
            this.LblKayıtlıKitapSayisi.BackColor = System.Drawing.Color.Transparent;
            this.LblKayıtlıKitapSayisi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKayıtlıKitapSayisi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblKayıtlıKitapSayisi.Location = new System.Drawing.Point(430, 572);
            this.LblKayıtlıKitapSayisi.Name = "LblKayıtlıKitapSayisi";
            this.LblKayıtlıKitapSayisi.Size = new System.Drawing.Size(130, 19);
            this.LblKayıtlıKitapSayisi.TabIndex = 42;
            this.LblKayıtlıKitapSayisi.Text = "Kayıtlı Kitap Sayisi";
            // 
            // LblKitapSayisi
            // 
            this.LblKitapSayisi.AutoSize = true;
            this.LblKitapSayisi.BackColor = System.Drawing.Color.Transparent;
            this.LblKitapSayisi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKitapSayisi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblKitapSayisi.Location = new System.Drawing.Point(683, 572);
            this.LblKitapSayisi.Name = "LblKitapSayisi";
            this.LblKitapSayisi.Size = new System.Drawing.Size(84, 19);
            this.LblKitapSayisi.TabIndex = 43;
            this.LblKitapSayisi.Text = "Kitap Sayisi";
            // 
            // TxtKitapSayi
            // 
            this.TxtKitapSayi.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.TxtKitapSayi.Location = new System.Drawing.Point(774, 569);
            this.TxtKitapSayi.MaxLength = 11;
            this.TxtKitapSayi.Name = "TxtKitapSayi";
            this.TxtKitapSayi.Size = new System.Drawing.Size(109, 26);
            this.TxtKitapSayi.TabIndex = 35;
            this.TxtKitapSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKayıtlıKitap
            // 
            this.txtKayıtlıKitap.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.txtKayıtlıKitap.Location = new System.Drawing.Point(567, 569);
            this.txtKayıtlıKitap.MaxLength = 11;
            this.txtKayıtlıKitap.Name = "txtKayıtlıKitap";
            this.txtKayıtlıKitap.Size = new System.Drawing.Size(109, 26);
            this.txtKayıtlıKitap.TabIndex = 44;
            // 
            // FrmEmanetKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1079, 615);
            this.Controls.Add(this.txtKayıtlıKitap);
            this.Controls.Add(this.TxtKitapSayi);
            this.Controls.Add(this.LblKitapSayisi);
            this.Controls.Add(this.LblKayıtlıKitapSayisi);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnTeslimEt);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.GrpKitapBilgileri);
            this.Controls.Add(this.GrupUyeBilgi);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmanetKitap";
            this.Text = "Emanet Kitap Verme Sayfası";
            this.Load += new System.EventHandler(this.FrmEmanetKitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrupUyeBilgi.ResumeLayout(false);
            this.GrupUyeBilgi.PerformLayout();
            this.GrpKitapBilgileri.ResumeLayout(false);
            this.GrpKitapBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GrupUyeBilgi;
        private System.Windows.Forms.GroupBox GrpKitapBilgileri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYas;
        private System.Windows.Forms.TextBox TxtBtnAdSoyad;
        private System.Windows.Forms.TextBox TxtBtnTc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSayfaSayisi;
        private System.Windows.Forms.DateTimePicker DtpiadeTarihi;
        private System.Windows.Forms.DateTimePicker DtpTeslimTarihi;
        private System.Windows.Forms.TextBox textBoxYayinevi;
        private System.Windows.Forms.TextBox textBoxYazari;
        private System.Windows.Forms.TextBox textBoxKitapAdi;
        private System.Windows.Forms.TextBox textBoxBarkodNo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.SimpleButton BtnGeri;
        private DevExpress.XtraEditors.SimpleButton BtnTeslimEt;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private System.Windows.Forms.Label LblKayıtlıKitapSayisi;
        private System.Windows.Forms.Label LblKitapSayisi;
        private System.Windows.Forms.TextBox TxtKitapSayi;
        private System.Windows.Forms.TextBox txtKayıtlıKitap;
    }
}