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

namespace _13SifreliVeriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=Udemy25Proje13;Integrated Security=True;TrustServerCertificate=True");
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLVERİLER", Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtad.Text;
            byte[] adDizisi =ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre = Convert.ToBase64String(adDizisi);

            string soyad = txtsoyad.Text;
            byte[] soyadDizisi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyadDizisi);

            string mail = txtmail.Text;
            byte[] mailDizisi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(mailDizisi);

            string sifre = txtsifre.Text;
            byte[] sifreDizisi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifreDizisi);

            string hesap = txthesap.Text;
            byte[] hesapDizisi = ASCIIEncoding.ASCII.GetBytes(hesap);
            string hesapsifre = Convert.ToBase64String(hesapDizisi);


            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblveriler (AD, SOYAD, MAIL, SIFRE, HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", Baglanti);
            komut.Parameters.AddWithValue("@p1", adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", mailsifre);
            komut.Parameters.AddWithValue("@p4", sifresifre);
            komut.Parameters.AddWithValue("@p5", hesapsifre);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Kayıt Eklendi");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adcozum = txtad.Text;
            byte[] adcozumsifre = Convert.FromBase64String(adcozum);
            string adverisi = ASCIIEncoding.ASCII.GetString(adcozumsifre);


            string soyadcozum = txtsoyad.Text;
            byte[] soyadcozumsifre = Convert.FromBase64String(soyadcozum);
            string soyadverisi = ASCIIEncoding.ASCII.GetString(soyadcozumsifre);

            string mailcozum = txtmail.Text;
            byte[] mailcozumsifre = Convert.FromBase64String(mailcozum);
            string mailverisi = ASCIIEncoding.ASCII.GetString(mailcozumsifre);


            string sifrecozum = txtsifre.Text;
            byte[] sifrecozumsifre = Convert.FromBase64String(sifrecozum);
            string sifreverisi = ASCIIEncoding.ASCII.GetString(sifrecozumsifre);


            string hesapcozum = txthesap.Text;
            byte[] hesapcozumsifre = Convert.FromBase64String(hesapcozum);
            string hesapverisi = ASCIIEncoding.ASCII.GetString(hesapcozumsifre);



        }
    }
}
