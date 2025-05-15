using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _17Yolcu_Bilet_Rezervasyon___Kayıt_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void seferListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLSEFERBILGI", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        SqlConnection connection = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=TestYolcuBilet;Integrated Security=True;TrustServerCertificate=True");
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TBLYOLCUBILGI (Ad, Soyad,Telefon,TC ,Cınsıyet,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", txtad.Text);
            command.Parameters.AddWithValue("@p2", txtsoyad.Text);
            command.Parameters.AddWithValue("@p3", msktel.Text);
            command.Parameters.AddWithValue("@p4", msktc.Text);
            command.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
            command.Parameters.AddWithValue("@p6", txtmail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnkaptan_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TBLKAPTAN (KAPTANNO,ADSOYAD,TELEFON) values (@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1", txtkaptanno.Text);
            command.Parameters.AddWithValue("@p2", txtkaptanad.Text);
            command.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kaptan Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnseferoluştur_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TBLSEFERBILGI (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", txtkalkıs.Text);
            command.Parameters.AddWithValue("@p2", txtkalkıs.Text);
            command.Parameters.AddWithValue("@p3", msktarih.Text);
            command.Parameters.AddWithValue("@p4", msksaat.Text);
            command.Parameters.AddWithValue("@p5", mskkaptan.Text);
            command.Parameters.AddWithValue("@p6", txtfiyat.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Sefer Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            seferListele();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtsefernumara.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "3";
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "22";
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "23";
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "21";
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "20";
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "19";
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "18";
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "17";
        }

        private void btn16_Click(object sender, EventArgs e)
        {
        txtkoltukno.Text = "16";
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "15";
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "14";
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "12";
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "13";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "11";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "10";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "6";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TBLSEFERDETAY (SEFERNO, YOLCUTC, KOLTUK) values (@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1", txtsefernumara.Text);
            command.Parameters.AddWithValue("@p2", mskyolcutc.Text);
            command.Parameters.AddWithValue("@p3", txtkoltukno.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool yolcuDurum;
        void yolcuKontrol()
        {
            try
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("select TC from TBLYOLCUBILGI where TC=@p1", connection);
                komut.Parameters.AddWithValue("@p1", mskyolcutc.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    yolcuDurum = true;
                }
                else
                {
                    yolcuDurum = false;
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Doğru bilgi giriniz");
            }


        }
        void yolcuBilgi()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLYOLCUBILGI where TC=@p1", connection);
            komut.Parameters.AddWithValue("@p1", mskyolcutc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktel.Text = dr[3].ToString();
                msktc.Text = dr[4].ToString();
                txtmail.Text = dr[6].ToString();
            }
            else
            {
                MessageBox.Show("Kullanıcı kaydı bulunamadı");
            }
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yolcuBilgi();
        }

        private void btnSeferBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            connection.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLSEFERBILGI WHERE TARIH = @tarih", connection);
            komut.Parameters.AddWithValue("@tarih", maskedTextBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
                da.Fill(dt);
            dataGridView1.DataSource = dt;


            connection.Close();

        }
    }
}
