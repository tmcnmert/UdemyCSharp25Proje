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

namespace _05FilmArsivi
{
    public partial class Tamekran : Form
    {
        public Tamekran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=dbFilmArsivi;Integrated Security=True;TrustServerCertificate=True");
        string secilen;
        private void Tamekran_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from  TBLFILMLER", baglanti);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())

            {



                secilen = dr[3].ToString();



                webBrowser1.Navigate(secilen);
            }
        }
    }
}
