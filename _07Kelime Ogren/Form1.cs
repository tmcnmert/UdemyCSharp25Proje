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

namespace _07Kelime_Ogren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=dbSozluk;Integrated Security=True;TrustServerCertificate=True");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txting.Text = dr[1].ToString();
                label4.Text = dr[2].ToString();
                label4.Text = label4.Text.ToLower();
            }
            baglanti.Close();

        }
        private void Form1_Load(object sender, EventArgs e) 
        {
            getir();
            timer1.Start();

        }

        private void txttr_TextChanged(object sender, EventArgs e)
        {
            if (txttr.Text == label4.Text)
            {
                kelime++;
                lblkemlime.Text = kelime.ToString();
                getir();
                txttr.Clear();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsüre.Text = sure.ToString();
            if (sure==0)
            {
                txttr.Enabled = false;
                txting.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Süre Bitti");
            }
        }
    }
}
