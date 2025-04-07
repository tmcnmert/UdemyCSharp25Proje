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

namespace _11Kullanıcılar_Arası_Veri_Tabanı_Bağlantısı_ile_Mesajlaşma_Sistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void gelenkutusu()
        {
            SqlDataAdapter da1= new SqlDataAdapter("Select MESAJID, (AD+ ' ' +SOYAD) AS GONDEREN,BASLIK,ICERIK From TBLMESAJLAR inner join TBLKISILER on TBLMESAJLAR.GONDEREN = TBLKISILER.NUMARA Where ALICI = " + numara, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select MESAJID, (AD+ ' ' +SOYAD) AS ALICI,BASLIK,ICERIK From TBLMESAJLAR inner join TBLKISILER on TBLMESAJLAR.ALICI = TBLKISILER.NUMARA Where GONDEREN = " + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            gelenkutusu();
            gidenkutusu();

            //ad soyad ve numara bilgilerini al
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Ad,Soyad from TBLKISILER where numara=" + numara , baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0]+" " + dr[1];
                lblnum.Text=numara;

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.Parameters.AddWithValue("@p4", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız Gönderilmiştir.");
            gidenkutusu();
        }
    }
}
