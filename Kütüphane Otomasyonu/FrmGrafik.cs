using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=BURAK\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

        DataSet daset = new DataSet();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa log = new FrmAnaSayfa();
            log.Show();
            this.Hide();

        }

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select AdSoyad,OkunanKitapSayisi from Uye", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                graphic.Series["Okunan kitap Sayısı"].Points.AddXY(read["AdSoyad"].ToString(), read["OkunanKitapSayisi"]);
            }
            baglanti.Close();
            graphic.Series["Okunan kitap Sayısı"].Color = Color.Blue;
        }
    }
}
