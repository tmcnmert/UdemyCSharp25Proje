using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _14BankaTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        

        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblKisiler (AD,SOYAD,TC,HESAPNO,TELEFON,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", mskhesapno.Text);
            komut.Parameters.AddWithValue("@p5", msktel.Text);
            komut.Parameters.AddWithValue("@p6", txtsifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi");
        }

        private void btnhesapno_Click(object sender, EventArgs e)
        {
            int arastir;
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000, 1000000);
            mskhesapno.Text = sayi.ToString();

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBLHESAP", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                arastir = Convert.ToInt32(dr[0]);
                if (arastir == sayi)
                {
                    mskhesapno.Text = rastgele.Next(100000, 1000000).ToString();
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
