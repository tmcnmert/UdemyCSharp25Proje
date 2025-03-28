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

namespace _1NotKayitSistemi
{
    public partial class frmogrdetay : Form
    {
        public frmogrdetay()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=dbNotKayit;Integrated Security=True;TrustServerCertificate=True");
        private void frmogrdetay_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLDERS WHERE OGRNUMARA=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text = dr[2].ToString()+" " + dr[3].ToString();
                lbls1.Text = dr[4].ToString();
                lbls2.Text = dr[5].ToString();
                lbls3.Text = dr[6].ToString();
                lblort.Text = dr[7].ToString();
                lbldurum.Text = dr[8].ToString();
            }
            baglanti.Close();
            
        }
    }
}
