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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=dbFilmArsivi;Integrated Security=True;TrustServerCertificate=True");
        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *  from TBLFILMLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFILMLER (AD,KATEGORI,LINK) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtfilmad.Text);
            komut.Parameters.AddWithValue("@p2", txtkategori.Text);
            komut.Parameters.AddWithValue("@p3", txtlink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void btnhakımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Mert Timoçin tarafından 28 Mart 2025'te yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnçık_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntamekran_Click(object sender, EventArgs e)
        {
            Tamekran frm = new Tamekran();
            frm.Show();
        }

        private void btnrenk_Click(object sender, EventArgs e)
        {
            Color[] renkler=new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Purple, Color.Orange, Color.Pink, Color.Brown, Color.Black, Color.White };
            Random rnd = new Random();
            int dizielemanı = rnd.Next(0, renkler.Length);
            this.BackColor = renkler[dizielemanı];
        }
        
    }
}
