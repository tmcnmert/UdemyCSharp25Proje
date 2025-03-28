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
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout;
using System.IO;
using System.Diagnostics;

namespace _12SqlSorguSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=mert\\SQLEXPRESS;Initial Catalog=" + cmbdb.Text + ";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand(richTextBox1.Text, baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from"+" "+cmbtable.Text,baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void DB()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=mert\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select name from sys.databases", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdb.Items.Add(dr[0].ToString());
            }
            baglanti.Close();
        }
        void TBL()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=mert\\SQLEXPRESS;Initial Catalog=" + cmbdb.Text + ";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from sys.Tables", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbtable.Items.Add(dr1[0].ToString());
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DB();
            SqlConnection baglanti = new SqlConnection("Data Source=mert\\SQLEXPRESS;Initial Catalog=" + cmbdb.Text + ";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }

        private void cmbdb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbtable.Items.Clear();
            TBL();
        }

        private void cmbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Select * from " + " " + cmbtable.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // PDF'nin kaynak yolu (proje içindeki konumu)
            string sourcePath = @"...";

            // Hedef yol: Kullanıcının Masaüstü
            string targetPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SQL_Notlar__1736717868.pdf");

            try
            {
                // PDF'yi hedef konuma kopyala
                File.Copy(sourcePath, targetPath, true);

                // PDF başarıyla kopyalandı mesajı
                MessageBox.Show("PDF başarıyla indirildi ve masaüstüne kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // PDF'yi otomatik olarak aç
                Process.Start("explorer.exe", targetPath);
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
