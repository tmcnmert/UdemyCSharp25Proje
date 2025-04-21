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
using System.Data.SqlClient;

namespace _14BankaTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public string hesap;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblhesapno.Text = hesap;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TblKisiler where HESAPNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", lblhesapno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1]+" " + dr[2];
                lbltc.Text = dr[3].ToString();
                lbltel.Text = dr[4].ToString();
            }
            baglanti.Close();
        }
        

        private void btngönder_Click(object sender, EventArgs e)
        {
            //gönderilen hesabın para artısı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLHESAP set  BAKİYE=BAKİYE+@p1 where hesapno=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txttutar.Text));
            komut.Parameters.AddWithValue("@p2", mskhesapno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();


            //gönderen hesabın para azalışı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update TBLHESAP set  BAKİYE=BAKİYE-@k1 where hesapno=@k2", baglanti);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(txttutar.Text));
            komut2.Parameters.AddWithValue("@k2", hesap);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Gönderim Başarılı");


            //hareketler tablosuna ekleme
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET (GONDEREN,ALICI,TUTAR) values (@p1,@p2,@p3)", baglanti);
            komut3.Parameters.AddWithValue("@p1", lblhesapno.Text);
            komut3.Parameters.AddWithValue("@p2", mskhesapno.Text);
            komut3.Parameters.AddWithValue("@p3", decimal.Parse(txttutar.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
        }
    }
}
