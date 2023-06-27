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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=BURAK\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

        private void BtnUyeEkle_Click(object sender, EventArgs e)
        {
            FrmUyeEkle log = new FrmUyeEkle();
            log.Show();
            this.Hide();
        }

        private void BtnUyeListele_Click(object sender, EventArgs e)
        {
            FrmUyeListeme log = new FrmUyeListeme();
            log.Show();
            this.Hide();
        }

        private void BtnKitapEkle_Click(object sender, EventArgs e)
        {
            FrmKitapEkle log = new FrmKitapEkle();
            log.Show();
            this.Hide();
        }

        private void BtnKitapListele_Click(object sender, EventArgs e)
        {
            FrmKitapListeleme log = new FrmKitapListeleme();
            log.Show();
            this.Hide();
        }

        private void BtnEmanetVerme_Click(object sender, EventArgs e)
        {
            FrmEmanetKitap log = new FrmEmanetKitap();
            log.Show();
            this.Hide();
        }

        private void BtnEmanetListeleme_Click(object sender, EventArgs e)
        {
            FrmEmanetKitapListe log = new FrmEmanetKitapListe();
            log.Show();
            this.Hide();
        }

        private void BtnEmanetKitapiade_Click(object sender, EventArgs e)
        {
            FrmEmanetKitapiade log = new FrmEmanetKitapiade();
            log.Show();
            this.Hide();
        }

        private void BtnSiralama_Click(object sender, EventArgs e)
        {
            FrmSiralama log = new FrmSiralama();
            log.Show();
            this.Hide();

        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafik log = new FrmGrafik();
            log.Show();
            this.Hide();
        }
    }
}
