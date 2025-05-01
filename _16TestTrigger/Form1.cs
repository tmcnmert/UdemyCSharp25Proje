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
using static DevExpress.Utils.HashCodeHelper.Blob;

namespace _16TestTrigger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = dbTest; Integrated Security = True;TrustServerCertificate=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLKITAPLAR", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void sayac()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("SELECT ADET FROM TBLSAYAC", connection);
            int kitapSayisi = Convert.ToInt32(komut.ExecuteScalar());
            label8.Text = kitapSayisi.ToString();
            connection.Close();
        }
        void kitapSil()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Delete from TBLKITAPLAR where ID=@p1", connection);
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            sayac();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKITAPLAR (AD, YAZAR, SAYFA,YAYINEVİ,TUR ) values (@p1,@p2,@p3,@p4,@p5)", connection);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtyazar.Text);
            komut.Parameters.AddWithValue("@p3", txtsayfa.Text);
            komut.Parameters.AddWithValue("@p4", txtyayınevi.Text);
            komut.Parameters.AddWithValue("@p5", txttur.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap Eklendi");
            listele();
            sayac();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtyayınevi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txttur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();



        }

        private void brnsil_Click(object sender, EventArgs e)
        {
            kitapSil();
            listele();
            sayac();

        }
    }
}
