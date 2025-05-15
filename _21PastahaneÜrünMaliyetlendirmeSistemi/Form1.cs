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
using DevExpress.DXTemplateGallery.Extensions;

namespace _21PastahaneÜrünMaliyetlendirmeSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = MERT\\SQLEXPRESS;Initial Catalog = TestMaliyet;Integrated Security = True;TrustServerCertificate=True");
        void MalzemeListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void ÜrünListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBLURUNLER", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        void Kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from TBlKASA", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void Ürünler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbürün.ValueMember = "URUNID";
            cmbürün.DisplayMember = "AD";
            cmbürün.DataSource = dt;
            baglanti.Close();
        }

        void Malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmalzeme.ValueMember = "MALZEMEID";
            cmbmalzeme.DisplayMember = "AD";
            cmbmalzeme.DataSource = dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListele();
            Ürünler();
            Malzemeler();
        }

        private void btnürünlistele_Click(object sender, EventArgs e)
        {
            ÜrünListesi();
        }

        private void btnmalzemelistele_Click(object sender, EventArgs e)
        {
            MalzemeListele();
        }

        private void btnkasa_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void btnçıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmalzemeekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER (AD,STOK,FIYAT,NOTLAR) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtmalzemead.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtmalzemestok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtmalzemefiyat.Text));
            komut.Parameters.AddWithValue("@p4", txtmalzemenot.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MalzemeListele();


        }

        private void btnürünekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER (AD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtürünad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ÜrünListesi();
        }

        private void btnurunolustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN (URUNID,MALZEMEID,MIKTAR,MALIYET) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbürün.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbmalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtürünmiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtmaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            listBox1.Items.Add(cmbmalzeme.Text+" - "+txtmaliyet.Text);

        }

        private void txtürünmiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (txtürünmiktar.Text == "")
            {
                txtürünmiktar.Text = "0";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select FIYAT from TBLMALZEMELER where MALZEMEID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbmalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtmaliyet.Text = dr["FIYAT"].ToString();
            }
            baglanti.Close();
            maliyet = Convert.ToDouble(txtmaliyet.Text) / 1000 * Convert.ToDouble(txtürünmiktar.Text);

            txtmaliyet.Text = maliyet.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtürünıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtürünad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
              

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(MALIYET) FROM TBLFIRIN WHERE URUNID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtürünıd.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtürünmfiyat.Text = dr[0].ToString();
            }
            baglanti.Close();


        }

        private void btnürüngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLURUNLER set MFIYAT=@p1,SFIYAT=@p2, STOK=@p3 where AD=@p4", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtürünmfiyat.Text));
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtürünsifyat.Text));
            komut.Parameters.AddWithValue("@p3", int.Parse(txtürünstok.Text));
            komut.Parameters.AddWithValue("@p4", txtürünad.Text.ToUpper());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ÜrünListesi();
            baglanti.Open();
            decimal cikti, girdi;
            cikti=Convert.ToDecimal(txtürünstok.Text)*Convert.ToDecimal(txtürünmfiyat.Text);
            girdi = Convert.ToDecimal(txtürünstok.Text) * Convert.ToDecimal(txtürünsifyat.Text)-cikti;

            SqlCommand komut2 = new SqlCommand("insert into TBLKASA (GIRIS,CIKIS) values (@p1,@p2)", baglanti);
            komut2.Parameters.AddWithValue("@p1", girdi);
            komut2.Parameters.AddWithValue("@p2", cikti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kasa Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
