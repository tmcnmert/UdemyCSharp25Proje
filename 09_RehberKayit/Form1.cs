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

namespace _09_RehberKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=dbRehber;Integrated Security=True;TrustServerCertificate=True");


        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from KİSİLER", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        void temizle()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            txtmail.Text = "";
            txtid.Text = "";
            msktel.Text = "";
            txtad.Focus();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KİSİLER (AD,SOYAD,TELEFON,MAIL) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktel.Text);
            komut.Parameters.AddWithValue("@p4", txtmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msktel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtmail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from KİSİLER where ID="+txtid.Text, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update KİSİLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,MAIL=@p4 where ID=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktel.Text);
            komut.Parameters.AddWithValue("@p4", txtmail.Text);
            komut.Parameters.AddWithValue("@p5", txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
            
        }
    }
}
