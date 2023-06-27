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
    public partial class FrmSiralama : Form
    {
        public FrmSiralama()
        {
            InitializeComponent();
        }
            

        SqlConnection baglanti = new SqlConnection(@"Data Source=BURAK\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

        DataSet daset = new DataSet();

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye order by OkunanKitapSayisi desc", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
            textBoxEnaz.Text = "";
            textBoxEncok.Text = "";
            textBoxEncok.Text = daset.Tables["Uye"].Rows[0]["AdSoyad"].ToString()+"=";
            textBoxEncok.Text += daset.Tables["Uye"].Rows[0]["OkunanKitapSayisi"].ToString();
            textBoxEnaz.Text += daset.Tables["Uye"].Rows[dataGridView1.Rows.Count-2]["AdSoyad"].ToString()+"=";
            textBoxEnaz.Text += daset.Tables["Uye"].Rows[dataGridView1.Rows.Count - 2]["OkunanKitapSayisi"].ToString();


        }

        private void FrmSiralama_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa log = new FrmAnaSayfa();
            log.Show();
            this.Hide();
        }
    }
}
