namespace Kütüphane_Otomasyonu
{
    partial class FrmKitapListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapListeleme));
            this.comboBoxTuru = new System.Windows.Forms.ComboBox();
            this.textBoxAçıklama = new System.Windows.Forms.TextBox();
            this.textBoxRafNo = new System.Windows.Forms.TextBox();
            this.textBoxStokSayısı = new System.Windows.Forms.TextBox();
            this.textBoxsSayfaSayisi = new System.Windows.Forms.TextBox();
            this.textBoxYayınevi = new System.Windows.Forms.TextBox();
            this.textBoxYazar = new System.Windows.Forms.TextBox();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxBarkod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxKitapBarkod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTuru
            // 
            this.comboBoxTuru.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxTuru.FormattingEnabled = true;
            this.comboBoxTuru.Items.AddRange(new object[] {
            "Roman",
            "Çocuk",
            "Aksiyon",
            "Romantık "});
            this.comboBoxTuru.Location = new System.Drawing.Point(184, 205);
            this.comboBoxTuru.Name = "comboBoxTuru";
            this.comboBoxTuru.Size = new System.Drawing.Size(214, 27);
            this.comboBoxTuru.TabIndex = 39;
            // 
            // textBoxAçıklama
            // 
            this.textBoxAçıklama.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAçıklama.Location = new System.Drawing.Point(184, 311);
            this.textBoxAçıklama.Multiline = true;
            this.textBoxAçıklama.Name = "textBoxAçıklama";
            this.textBoxAçıklama.Size = new System.Drawing.Size(214, 127);
            this.textBoxAçıklama.TabIndex = 38;
            // 
            // textBoxRafNo
            // 
            this.textBoxRafNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRafNo.Location = new System.Drawing.Point(184, 276);
            this.textBoxRafNo.Name = "textBoxRafNo";
            this.textBoxRafNo.Size = new System.Drawing.Size(214, 26);
            this.textBoxRafNo.TabIndex = 37;
            // 
            // textBoxStokSayısı
            // 
            this.textBoxStokSayısı.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxStokSayısı.Location = new System.Drawing.Point(184, 241);
            this.textBoxStokSayısı.Name = "textBoxStokSayısı";
            this.textBoxStokSayısı.Size = new System.Drawing.Size(214, 26);
            this.textBoxStokSayısı.TabIndex = 36;
            // 
            // textBoxsSayfaSayisi
            // 
            this.textBoxsSayfaSayisi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxsSayfaSayisi.Location = new System.Drawing.Point(184, 170);
            this.textBoxsSayfaSayisi.Name = "textBoxsSayfaSayisi";
            this.textBoxsSayfaSayisi.Size = new System.Drawing.Size(214, 26);
            this.textBoxsSayfaSayisi.TabIndex = 35;
            // 
            // textBoxYayınevi
            // 
            this.textBoxYayınevi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYayınevi.Location = new System.Drawing.Point(184, 135);
            this.textBoxYayınevi.Name = "textBoxYayınevi";
            this.textBoxYayınevi.Size = new System.Drawing.Size(214, 26);
            this.textBoxYayınevi.TabIndex = 34;
            // 
            // textBoxYazar
            // 
            this.textBoxYazar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYazar.Location = new System.Drawing.Point(184, 100);
            this.textBoxYazar.Name = "textBoxYazar";
            this.textBoxYazar.Size = new System.Drawing.Size(214, 26);
            this.textBoxYazar.TabIndex = 33;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKitapAdi.Location = new System.Drawing.Point(184, 65);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(214, 26);
            this.textBoxKitapAdi.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(70, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Açıklama :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(82, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Raf No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(49, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Stok Sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(102, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Türü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sayfa Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(90, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(88, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Yazarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kitap Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kitap Barkod No :";
            // 
            // txtBoxBarkod
            // 
            this.txtBoxBarkod.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxBarkod.Location = new System.Drawing.Point(184, 30);
            this.txtBoxBarkod.Name = "txtBoxBarkod";
            this.txtBoxBarkod.Size = new System.Drawing.Size(214, 26);
            this.txtBoxBarkod.TabIndex = 22;
            this.txtBoxBarkod.TextChanged += new System.EventHandler(this.txtBoxBarkod_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(416, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 278);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(658, 392);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(100, 35);
            this.BtnSil.TabIndex = 43;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeri.Appearance.Options.UseFont = true;
            this.BtnGeri.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnGeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGeri.ImageOptions.Image")));
            this.BtnGeri.Location = new System.Drawing.Point(783, 392);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(100, 35);
            this.BtnGeri.TabIndex = 41;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(523, 392);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(100, 35);
            this.BtnGuncelle.TabIndex = 40;
            this.BtnGuncelle.Text = "Gümcelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(532, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 23);
            this.label10.TabIndex = 45;
            this.label10.Text = "Kitap Barkod No Ara :";
            // 
            // txtBxKitapBarkod
            // 
            this.txtBxKitapBarkod.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxKitapBarkod.Location = new System.Drawing.Point(735, 39);
            this.txtBxKitapBarkod.Name = "txtBxKitapBarkod";
            this.txtBxKitapBarkod.Size = new System.Drawing.Size(214, 26);
            this.txtBxKitapBarkod.TabIndex = 44;
            this.txtBxKitapBarkod.TextChanged += new System.EventHandler(this.txtBxKitapBarkod_TextChanged);
            // 
            // FrmKitapListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBxKitapBarkod);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.comboBoxTuru);
            this.Controls.Add(this.textBoxAçıklama);
            this.Controls.Add(this.textBoxRafNo);
            this.Controls.Add(this.textBoxStokSayısı);
            this.Controls.Add(this.textBoxsSayfaSayisi);
            this.Controls.Add(this.textBoxYayınevi);
            this.Controls.Add(this.textBoxYazar);
            this.Controls.Add(this.textBoxKitapAdi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxBarkod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKitapListeleme";
            this.Text = "Kitap Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FrmKitapListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGeri;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private System.Windows.Forms.ComboBox comboBoxTuru;
        private System.Windows.Forms.TextBox textBoxAçıklama;
        private System.Windows.Forms.TextBox textBoxRafNo;
        private System.Windows.Forms.TextBox textBoxStokSayısı;
        private System.Windows.Forms.TextBox textBoxsSayfaSayisi;
        private System.Windows.Forms.TextBox textBoxYayınevi;
        private System.Windows.Forms.TextBox textBoxYazar;
        private System.Windows.Forms.TextBox textBoxKitapAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxBarkod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBxKitapBarkod;
    }
}