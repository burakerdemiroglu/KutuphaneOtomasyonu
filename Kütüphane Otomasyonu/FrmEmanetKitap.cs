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
    public partial class FrmEmanetKitap : Form
    {
        public FrmEmanetKitap()
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

        DataSet daset = new DataSet();


        private void SepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Sepet", baglanti);
            adtr.Fill(daset, "Sepet");
            dataGridView1.DataSource = daset.Tables["Sepet"];
            baglanti.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Sepet(BarkodNo,KitapAdi,Yazari,Yayinevi,SayfaSayisi,KitapSayisi,TeslimTarihi,iadeTarihi) values (@BarkodNo,@KitapAdi,@Yazari,@Yayinevi,@SayfaSayisi,@KitapSayisi,@TeslimTarihi,@iadeTarihi)", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", textBoxBarkodNo.Text);
                komut.Parameters.AddWithValue("@KitapAdi", textBoxKitapAdi.Text);
                komut.Parameters.AddWithValue("@Yazari", textBoxYazari.Text);
                komut.Parameters.AddWithValue("@Yayinevi", textBoxYayinevi.Text);
                komut.Parameters.AddWithValue("@SayfaSayisi", textBoxSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@KitapSayisi", 1);
                komut.Parameters.AddWithValue("@TeslimTarihi", DtpTeslimTarihi.Text);
                komut.Parameters.AddWithValue("@iadeTarihi", DtpiadeTarihi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                daset.Tables["Sepet"].Clear();

                SepetListele();
                TxtKitapSayi.Text = "";
                KitapSayisi();

                MessageBox.Show("Başarıyla Eklendi");

                textBoxBarkodNo.Text = "";
                textBoxKitapAdi.Text = "";
                textBoxYazari.Text = "";
                textBoxYayinevi.Text = "";
                textBoxSayfaSayisi.Text = ""; 
                DtpTeslimTarihi.Text = "";
                DtpiadeTarihi.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Kitap sayısında hata olabilir. Lütfen kontrol ediniz.");
            }
            
        }

        private void FrmEmanetKitap_Load(object sender, EventArgs e)
        {
            SepetListele();
            KitapSayisi();
        }

        private void TxtBtnTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"select * from Uye where TC like '{TxtBtnTc.Text}'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                TxtBtnAdSoyad.Text = read["AdSoyad"].ToString();
                textBoxYas.Text = read["Yas"].ToString();
                maskedTextBoxTelefon.Text = read["Telefon"].ToString();
            }
            baglanti.Close();

            //Komut 2
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand($"select sum(KitapSayisi) from EmanetKitaplar where TC='{TxtBtnTc.Text}'", baglanti);
            txtKayıtlıKitap.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();

            if (TxtBtnTc.Text == "")
            {
                foreach (Control item in GrupUyeBilgi.Controls)
                {

                    if (item is TextBox)
                    {
                        item.Text = ""; 
                    }

                }
            }

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
                    SqlCommand komut = new SqlCommand("delete from Sepet where BarkodNo=@BarkodNo", baglanti);
                    komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Silme İşlemi gerçekleşti.");

                    daset.Tables["Sepet"].Clear();

                    SepetListele();
                    TxtKitapSayi.Text = "";
                    KitapSayisi();

                }
                else
                {
                    MessageBox.Show("Birden fazla satır seçtiniz veya satır bulunamamaktadır. Lütfen düzeltin.");
                }
            }
        }

        private void textBoxBarkodNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open(); 
            }
            catch (InvalidOperationException)
            { 
            }
            SqlCommand komut = new SqlCommand($"select * from Kitap where BarkodNo like '{textBoxBarkodNo.Text}'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                textBoxKitapAdi.Text = read["KitapAdi"].ToString();
                textBoxYazari.Text = read["Yazari"].ToString();
                textBoxYayinevi.Text = read["Yayinevi"].ToString();
                textBoxSayfaSayisi.Text = read["SayfaSayisi"].ToString();
            }
            baglanti.Close();

            if (textBoxBarkodNo.Text == "")
            {
                foreach (Control item in GrpKitapBilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != TxtKitapSayi)
                        {
                            item.Text = "";
                        }
                    }

                }
            }

        }


        private void KitapSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(KitapSayisi) from Sepet", baglanti);
            TxtKitapSayi.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }

        private void BtnTeslimEt_Click(object sender, EventArgs e)
        {
            if (TxtKitapSayi.Text != "")
            {
                //txtKayıtlıKitap
                //    TxtKitapSayi
                if (txtKayıtlıKitap.Text == "" && int.Parse(TxtKitapSayi.Text) <= 3 || txtKayıtlıKitap.Text != "" && int.Parse(txtKayıtlıKitap.Text) + int.Parse(TxtKitapSayi.Text) <= 3)
                {
                    if (TxtBtnTc.Text != "" && TxtBtnAdSoyad.Text != "" && textBoxYas.Text != "" && maskedTextBoxTelefon.Text != "")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into EmanetKitaplar(TC,AdSoyad,Yas,Telefon,BarkodNo,KitapAdi,Yazari,YayinEvi,SayfaSayisi,KitapSayisi,TeslimTarihi,iadeTarihi) values (@TC,@AdSoyad,@Yas,@Telefon,@BarkodNo,@KitapAdi,@Yazari,@YayinEvi,@SayfaSayisi,@KitapSayisi,@TeslimTarihi,@iadeTarihi)", baglanti);
                            komut.Parameters.AddWithValue("@TC", TxtBtnTc.Text);
                            komut.Parameters.AddWithValue("@AdSoyad", TxtBtnAdSoyad.Text);
                            komut.Parameters.AddWithValue("@Yas", textBoxYas.Text);
                            komut.Parameters.AddWithValue("@Telefon", maskedTextBoxTelefon.Text);
                            komut.Parameters.AddWithValue("BarkodNo", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                            komut.Parameters.AddWithValue("KitapAdi", dataGridView1.Rows[i].Cells["KitapAdi"].Value.ToString());
                            komut.Parameters.AddWithValue("Yazari", dataGridView1.Rows[i].Cells["Yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("YayinEvi", dataGridView1.Rows[i].Cells["YayinEvi"].Value.ToString());
                            komut.Parameters.AddWithValue("SayfaSayisi", dataGridView1.Rows[i].Cells["SayfaSayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("KitapSayisi", int.Parse(dataGridView1.Rows[i].Cells["KitapSayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("TeslimTarihi", dataGridView1.Rows[i].Cells["TeslimTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("iadeTarihi", dataGridView1.Rows[i].Cells["iadeTarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("update Uye set OkunanKitapSayisi=OkunanKitapSayisi+'" + int.Parse(dataGridView1.Rows[i].Cells["KitapSayisi"].Value.ToString()) + "'where TC='" + TxtBtnTc.Text + "' ", baglanti);
                            komut2.ExecuteNonQuery();
                            SqlCommand komut3 = new SqlCommand("update Kitap set StokSayisi=StokSayisi-+'" + int.Parse(dataGridView1.Rows[i].Cells["KitapSayisi"].Value.ToString()) + "'where BarkodNo='" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();

                        SqlCommand komut4 = new SqlCommand("delete from Sepet", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Kitaplar emanet edildi.");
                        daset.Tables["Sepet"].Clear();
                        SepetListele();
                        TxtBtnTc.Text = ""; 
                        KitapSayisi(); 
                    }
                    else
                    {
                        MessageBox.Show("Önce üye ismi seçmeniz gereklidir.", "Uyarı");
                    }

                }
                else
                {
                    MessageBox.Show("Emanet kitap Sayısı 3 ten fazla olamaz !", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Önce Sepete Kitap Eklenmelidir.", "Uyarı");
            }
        }
    }
}
