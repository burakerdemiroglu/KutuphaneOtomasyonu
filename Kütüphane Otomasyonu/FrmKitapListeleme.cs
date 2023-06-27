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
    public partial class FrmKitapListeleme : Form
    {
        public FrmKitapListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=BURAK\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

        DataSet daset = new DataSet();

        private void KitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }


        private void FrmKitapListeleme_Load(object sender, EventArgs e)
        {
            comboBoxTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            KitapListele();
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
                    SqlCommand komut = new SqlCommand("delete from Kitap where BarkodNo=@BarkodNo", baglanti);
                    komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Silme İşlemi gerçekleşti.");

                    daset.Tables["Kitap"].Clear();

                    KitapListele();

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
                else
                {
                    MessageBox.Show("Birden fazla satır seçtiniz veya satır bulunamamaktadır. Lütfen düzeltin.");
                }
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kitap set BarkodNo=@BarkodNo,KitapAdi=@KitapAdi,Yazari=@Yazari,Yayinevi=@Yayinevi,SayfaSayisi=@SayfaSayisi,Turu=@Turu,RafNo=@RafNo,Aciklama=@Aciklama where BarkodNo=@BarkodNo", baglanti);

            komut.Parameters.AddWithValue("@BarkodNo", txtBoxBarkod.Text); 
            komut.Parameters.AddWithValue("@KitapAdi", textBoxKitapAdi.Text);
            komut.Parameters.AddWithValue("@Yazari", textBoxYazar.Text);
            komut.Parameters.AddWithValue("@Yayinevi", textBoxYayınevi.Text);
            komut.Parameters.AddWithValue("@SayfaSayisi", textBoxsSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@Turu", comboBoxTuru.Text);
            komut.Parameters.AddWithValue("@StokSayisi", textBoxStokSayısı.Text);
            komut.Parameters.AddWithValue("@RafNo", textBoxRafNo.Text);
            komut.Parameters.AddWithValue("@Aciklama", textBoxAçıklama.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Güncelleme İşlemi Başarı ile gerçekleşti.");

            daset.Tables["Kitap"].Clear();

            KitapListele();

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
        
        private void txtBxKitapBarkod_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap where BarkodNo like '%" + txtBxKitapBarkod.Text + "%'", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa log = new FrmAnaSayfa();
            log.Show();
            this.Hide();
        }

        private void txtBoxBarkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"select * from Kitap where BarkodNo='{txtBoxBarkod.Text}'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txtBoxBarkod.Text = read["BarkodNo"].ToString();
                textBoxKitapAdi.Text = read["KitapAdi"].ToString();
                textBoxYazar.Text = read["Yazari"].ToString();
                textBoxYayınevi.Text = read["Yayinevi"].ToString();
                textBoxsSayfaSayisi.Text = read["SayfaSayisi"].ToString();
                comboBoxTuru.Text = read["Turu"].ToString();
                textBoxStokSayısı.Text = read["StokSayisi"].ToString();
                textBoxRafNo.Text = read["RafNo"].ToString();
                textBoxAçıklama.Text = read["Aciklama"].ToString();
            }
            baglanti.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtBoxBarkod.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
                textBoxKitapAdi.Text = dataGridView1.CurrentRow.Cells["KitapAdi"].Value.ToString();
                textBoxYazar.Text = dataGridView1.CurrentRow.Cells["Yazari"].Value.ToString();
                textBoxYayınevi.Text = dataGridView1.CurrentRow.Cells["Yayinevi"].Value.ToString();
                textBoxsSayfaSayisi.Text = dataGridView1.CurrentRow.Cells["SayfaSayisi"].Value.ToString();
                comboBoxTuru.Text = dataGridView1.CurrentRow.Cells["Turu"].Value.ToString();
                textBoxStokSayısı.Text = dataGridView1.CurrentRow.Cells["StokSayisi"].Value.ToString();
                textBoxRafNo.Text = dataGridView1.CurrentRow.Cells["RafNo"].Value.ToString();
                textBoxAçıklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Gridde hata olabilir. Veriler textboxlara aktarılamıyor");
            }
        }
    }
}
