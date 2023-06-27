using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyonu
{
    public partial class FrmUyeEkle : Form
    {
        public FrmUyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=BURAK\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");


        private void Btniptal_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa log = new FrmAnaSayfa();
            log.Show();
            this.Hide();


        }

        private void BtnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Uye(TC,AdSoyad,Yas,Cinsiyet,Telefon,Adres,Email,OkunanKitapSayisi) values (@TC,@AdSoyad,@Yas,@Cinsiyet,@Telefon,@Adres,@Email,@OkunanKitapSayisi)", baglanti);
            komut.Parameters.AddWithValue("@TC",TxtBtnTc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", TxtBtnAdSoyad.Text);
            komut.Parameters.AddWithValue("@Yas", TxtBtnYas.Text);
            komut.Parameters.AddWithValue("@Cinsiyet",CombomaxCinsiyet.Text);
            komut.Parameters.AddWithValue("@Telefon", maskedTextBoxTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", TxtBtnAdres.Text);
            komut.Parameters.AddWithValue("@Email", TxtBtnEmail.Text);
            komut.Parameters.AddWithValue("@OkunanKitapSayisi", TxtBtnOkunanKitapSayisi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Yapıldı.");

            TxtBtnAdSoyad.Text = "";
            TxtBtnTc.Text = "";
            TxtBtnYas.Text = "";
            TxtBtnEmail.Text = "";
            TxtBtnAdres.Text = "";
            TxtBtnOkunanKitapSayisi.Text = "";
            maskedTextBoxTelefon.Text = "";
            CombomaxCinsiyet.Text = "";

        }

        private void FrmUyeEkle_Load(object sender, EventArgs e)
        {
            CombomaxCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
