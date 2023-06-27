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
using System.Data.Sql;

namespace Kütüphane_Otomasyonu
{
    public partial class FrmEmanetKitapiade : Form
    {
        public FrmEmanetKitapiade()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=BURAK\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa log = new FrmAnaSayfa();
            log.Show();
            this.Hide();
        }
        DataSet daset = new DataSet();

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void FrmEmanetKitapiade_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void textBoxTC_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where TC like '%"+textBoxTC.Text+"%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
            if (textBoxTC.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void textBoxBarkodno_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where BarkodNo like '%" + textBoxBarkodno.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
            if (textBoxBarkodno.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kitap iade işlemini onaylıyor musunuz?", "İade", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    string TC = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
                    string BarkodNo = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from EmanetKitaplar where TC=@TC and BarkodNo=@BarkodNo", baglanti);
                    komut.Parameters.AddWithValue("@TC", TC);
                    komut.Parameters.AddWithValue("@BarkodNo", BarkodNo);
                    komut.ExecuteNonQuery(); 
                     
                    SqlCommand komut2 = new SqlCommand($"update Kitap set stoksayisi=stoksayisi+1 where BarkodNo='{BarkodNo}'", baglanti);
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    daset.Tables["EmanetKitaplar"].Clear();
                    EmanetListele();
                }
                else
                {
                    MessageBox.Show("Birden fazla satır seçtiniz veya satır bulunamamaktadır. Lütfen düzeltin.");
                }
            } 
        }
    }
}
