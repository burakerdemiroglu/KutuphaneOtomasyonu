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
    public partial class FrmUyeListeme : Form
    {
        public FrmUyeListeme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=BURAK\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

        private void TxtBtnTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"select * from Uye where TC='{TxtBtnTc.Text}'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                TxtBtnTc.Text = read["TC"].ToString();
                TxtBtnAdSoyad.Text = read["AdSoyad"].ToString();
                TxtBtnYas.Text = read["Yas"].ToString();
                CombomaxCinsiyet.Text = read["Cinsiyet"].ToString();
                maskedTextBoxTelefon.Text = read["Telefon"].ToString();
                TxtBtnAdres.Text = read["Adres"].ToString();
                TxtBtnEmail.Text = read["Email"].ToString();
                TxtBtnOkunanKitapSayisi.Text = read["OkunanKitapSayisi"].ToString();
            }
            baglanti.Close();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtBtnTc.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
                TxtBtnAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
                TxtBtnYas.Text = dataGridView1.CurrentRow.Cells["Yas"].Value.ToString();
                CombomaxCinsiyet.Text = dataGridView1.CurrentRow.Cells["Cinsiyet"].Value.ToString();
                maskedTextBoxTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
                TxtBtnAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
                TxtBtnEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                TxtBtnOkunanKitapSayisi.Text = dataGridView1.CurrentRow.Cells["OkunanKitapSayisi"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Gridde hata olabilir. Veriler textboxlara aktarılamıyor");
            }

        }
        DataSet daset = new DataSet();

        private void TxtTcAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Uye"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye where TC like '%" + TxtTcAra.Text + "%'", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Silme işlemi onaylıyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                { 
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Uye where TC=@TC", baglanti);
                    komut.Parameters.AddWithValue("@TC", dataGridView1.CurrentRow.Cells["TC"].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Silme İşlemi gerçekleşti.");

                    daset.Tables["Uye"].Clear();

                    UyeListele();

                    TxtBtnAdSoyad.Text = "";
                    TxtBtnTc.Text = "";
                    TxtBtnYas.Text = "";
                    TxtBtnEmail.Text = "";
                    TxtBtnAdres.Text = "";
                    TxtBtnOkunanKitapSayisi.Text = "";
                    maskedTextBoxTelefon.Text = "";
                    CombomaxCinsiyet.Text = "";
                }
                else
                {
                    MessageBox.Show("Birden fazla satır seçtiniz veya satır bulunamamaktadır. Lütfen düzeltin.");
                }
            }

        }

        private void UyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
        }

        private void FrmUyeListeme_Load(object sender, EventArgs e)
        {
            UyeListele();
            CombomaxCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Uye set AdSoyad=@Adsoyad,yas=@yas,Cinsiyet=@Cinsiyet,Telefon=@Telefon,Adres=@Adres,Email=@Email,OkunanKitapSayisi=@OkunanKitapSayisi where TC=@TC", baglanti);
            komut.Parameters.AddWithValue("@TC", TxtBtnTc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", TxtBtnAdSoyad.Text);
            komut.Parameters.AddWithValue("@Yas", TxtBtnYas.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", CombomaxCinsiyet.Text);
            komut.Parameters.AddWithValue("@Telefon", maskedTextBoxTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", TxtBtnAdres.Text);
            komut.Parameters.AddWithValue("@Email", TxtBtnEmail.Text);
            komut.Parameters.AddWithValue("@OkunanKitapSayisi", TxtBtnOkunanKitapSayisi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarı ile gerçekleşti.");
            daset.Tables["Uye"].Clear();
            UyeListele();
            TxtBtnAdSoyad.Text = "";
            TxtBtnTc.Text = "";
            TxtBtnYas.Text = "";
            TxtBtnEmail.Text = "";
            TxtBtnAdres.Text = "";
            TxtBtnOkunanKitapSayisi.Text = "";
            maskedTextBoxTelefon.Text = "";
            CombomaxCinsiyet.Text = "";
        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa log = new FrmAnaSayfa();
            log.Show();
            this.Hide();
        }

        
    }
}
