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
    public partial class FrmKitapEkle : Form
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=BURAK\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa log = new FrmAnaSayfa();
            log.Show();
            this.Hide();
        }

        private void FrmKitapEkle_Load(object sender, EventArgs e)
        {
            comboBoxTuru.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap(BarkodNo,KitapAdi,Yazari,Yayinevi,SayfaSayisi,Turu,StokSayisi,RafNo,Aciklama,KayitTarihi) values (@BarkodNo,@KitapAdi,@Yazari,@Yayinevi,@SayfaSayisi,@Turu,@StokSayisi,@RafNo,@Aciklama,@KayitTarihi)", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", txtBoxBarkod.Text);
            komut.Parameters.AddWithValue("@KitapAdi", textBoxKitapAdi.Text);
            komut.Parameters.AddWithValue("@Yazari", textBoxYazar.Text);
            komut.Parameters.AddWithValue("@Yayinevi", textBoxYayınevi.Text);
            komut.Parameters.AddWithValue("@SayfaSayisi", textBoxsSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@Turu",comboBoxTuru.Text);
            komut.Parameters.AddWithValue("@StokSayisi", textBoxStokSayısı.Text);
            komut.Parameters.AddWithValue("@RafNo", textBoxRafNo.Text);
            komut.Parameters.AddWithValue("@Aciklama", textBoxAçıklama.Text);
            komut.Parameters.AddWithValue("@KayitTarihi", DateTime.Now.ToShortDateString());

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Yapıldı.");

            txtBoxBarkod.Text = "";
            textBoxKitapAdi.Text = "";
            textBoxYazar.Text = "";
            textBoxYayınevi.Text = "";
            textBoxsSayfaSayisi.Text = "";
            comboBoxTuru.Text = "";
            textBoxStokSayısı.Text = "";
            textBoxAçıklama.Text = "";
            textBoxRafNo.Text = "";
        }

        private void comboBoxTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
