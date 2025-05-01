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
using System.IO;

namespace _15_EtütSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=Etüt Test;Integrated Security=True;TrustServerCertificate=True");
        void dersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.DisplayMember = "DERSAD"; 
            cmbders.ValueMember = "DERSID";
            cmbders.DataSource = dt;
            cmbogretmenbrans.DisplayMember = "DERSAD";
            cmbogretmenbrans.ValueMember = "DERSID";
            cmbogretmenbrans.DataSource = dt;

        }
        void etütListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("execute etut", baglanti);
            DataTable dt = new DataTable();
            da2.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etütListesi();
        }

        private void cmbders_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter ogrtGetir = new SqlDataAdapter("SELECT OGRTID,(AD +' '+SOYAD) AS ADSOYAD FROM TBLOGRETMEN WHERE BRANSID=" + cmbders.SelectedValue, baglanti);
            DataTable dataTable = new DataTable();
            ogrtGetir.Fill(dataTable);
            cmbogr.DisplayMember = "ADSOYAD";
            cmbogr.ValueMember = "OGRTID";
            cmbogr.DataSource = dataTable;
        }

        private void btnetutolustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbders.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbogr.SelectedValue);
            komut.Parameters.AddWithValue("@p3", msktarih.Text);
            komut.Parameters.AddWithValue("@p4", msksaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnetütver_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbletut set OGRENCIID=@p1,DURUM=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtogrid.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnogrekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", txtsınıf.Text);
            komut.Parameters.AddWithValue("@p5", msktel.Text);
            komut.Parameters.AddWithValue("@p6", txtmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnogretmenekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRETMEN (AD,SOYAD,BRANSID) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtogretmenad.Text);
            komut.Parameters.AddWithValue("@p2", txtogretmensoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbogretmenbrans.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğretmen Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmbogretmenbrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
