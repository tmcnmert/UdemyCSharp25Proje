using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _18Petrol___Akaryakıt_Stok_Takip_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=TestBenzin;Integrated Security=True;TrustServerCertificate=True");

        void fiyatListele()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=TestBenzin;Integrated Security=True;TrustServerCertificate=True"))
            {
                baglanti.Open();

                // Tüm verileri bir seferde çekelim
                SqlCommand komut = new SqlCommand("SELECT * FROM TBLBENZIN", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    string tur = dr["PETROLTUR"].ToString();
                    string alis = dr["ALISFIYAT"].ToString();
                    string satis = dr["SATISFIYAT"].ToString();
                    string stok = dr["STOK"].ToString();

                    switch (tur)
                    {
                        case "Kurşunsuz95":
                            lblkursunsuz95.Text = satis;
                            lblkursunsuz95alıs.Text = alis;
                            progressBar1.Value = Convert.ToInt32(stok);
                            lblkursunsuz95litre.Text = stok;
                            break;
                        case "Kurşunsuz97":
                            lblkursunsuz97.Text = satis;
                            lblkursunsuz97alıs.Text = alis;
                            progressBar2.Value = Convert.ToInt32(stok);
                            lblkursunsuz97litre.Text = stok;
                            break;
                        case "EuroDizel10":
                            lbleurodizel10.Text = satis;
                            lbleurodizel10alıs.Text = alis;
                            progressBar3.Value = Convert.ToInt32(stok);
                            lbleurodizellitre.Text = stok;
                            break;
                        case "YeniProDizel":
                            lblyeniprodizel.Text = satis;
                            lblyeniprodizelalıs.Text = alis;
                            progressBar4.Value = Convert.ToInt32(stok);
                            lblyeniprodizellitre.Text = stok;
                            break;
                        case "Gaz":
                            lblgaz.Text = satis;
                            lblgazalıs.Text = alis;
                            progressBar5.Value = Convert.ToInt32(stok);
                            lblgazlitre.Text = stok;
                            break;
                    }
                }
                dr.Close();

                // Kasa bilgisi
                SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLKASA", baglanti);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    lblkasa.Text = dr2[0].ToString();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            fiyatListele();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(lblkursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            txtkursunsuz95fiyat.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(lblkursunsuz97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = kursunsuz97 * litre;
            txtkursunsuz97fiyat.Text = tutar.ToString();

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel10, litre, tutar;
            eurodizel10 = Convert.ToDouble(lbleurodizel10.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = eurodizel10 * litre;
            txteurodizelfiyat.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double yeniprodizel, litre, tutar;
            yeniprodizel = Convert.ToDouble(lblyeniprodizel.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = yeniprodizel * litre;
            txtyenidizelfiyat.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblgaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gaz * litre;
            txtgazfiyat.Text = tutar.ToString();

        }

        private void btndepodoldur_Click(object sender, EventArgs e)
        {
            if (txtplaka.Text == "")
            {
                MessageBox.Show("Lütfen Plaka Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (numericUpDown1.Value != 0)
                {
                    //
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtplaka.Text);
                    komut.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                    komut.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                    komut.Parameters.AddWithValue("@p4", decimal.Parse(txtkursunsuz95fiyat.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    //Kasa Güncelleme
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtkursunsuz95fiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();



                    //Depo Güncelleme
                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Kurşunsuz95'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kurşunsuz95 Benzin Alım İşlemi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fiyatListele();
                }
                if (numericUpDown2.Value != 0)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtplaka.Text);
                    komut.Parameters.AddWithValue("@p2", "Kurşunsuz97");
                    komut.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                    komut.Parameters.AddWithValue("@p4", decimal.Parse(txtkursunsuz97fiyat.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    //Kasa Güncelleme
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtkursunsuz97fiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    //Depo Güncelleme
                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Kurşunsuz97'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown2.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kurşunsuz97 Benzin Alım İşlemi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fiyatListele();

                }
                if (numericUpDown3.Value != 0)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtplaka.Text);
                    komut.Parameters.AddWithValue("@p2", "EuroDizel10");
                    komut.Parameters.AddWithValue("@p3", numericUpDown3.Value);
                    komut.Parameters.AddWithValue("@p4", decimal.Parse(txteurodizelfiyat.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    //Kasa Güncelleme
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(txteurodizelfiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    //Depo Güncelleme
                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='EuroDizel10'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown3.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("EuroDizel10  Alım İşlemi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fiyatListele();
                }
                if (numericUpDown4.Value != 0)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtplaka.Text);
                    komut.Parameters.AddWithValue("@p2", "YeniProDizel");
                    komut.Parameters.AddWithValue("@p3", numericUpDown4.Value);
                    komut.Parameters.AddWithValue("@p4", decimal.Parse(txtyenidizelfiyat.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    //Kasa Güncelleme
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtyenidizelfiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    //Depo Güncelleme
                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='YeniProDizel'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown4.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("YeniProDizel  Alım İşlemi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fiyatListele();


                }
                if (numericUpDown5.Value != 0)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtplaka.Text);
                    komut.Parameters.AddWithValue("@p2", "Gaz");
                    komut.Parameters.AddWithValue("@p3", numericUpDown5.Value);
                    komut.Parameters.AddWithValue("@p4", decimal.Parse(txtgazfiyat.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    //Kasa Güncelleme
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtgazfiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    //Depo Güncelleme
                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Gaz'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown5.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Gaz  Alım İşlemi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fiyatListele();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kursunsuz95 = Convert.ToDouble(lblkursunsuz95alıs.Text);
            double kursunsuz97 = Convert.ToDouble(lblkursunsuz97alıs.Text);
            double eurodizel10 = Convert.ToDouble(lbleurodizel10alıs.Text);
            double yeniprodizel = Convert.ToDouble(lblyeniprodizelalıs.Text);
            double gaz = Convert.ToDouble(lblgazalıs.Text);

            int litre95 = int.Parse(kursunsuz95alıslitre.Text);
            int litre97 = int.Parse(kursunsuz97alıslitre.Text);
            int litreDizel = int.Parse(eurodizel10alıslitre.Text);
            int litreYeniDizel = int.Parse(yeniprodizelalıslitre.Text);
            int litreGaz = int.Parse(gazalıslitre.Text);

            double toplam =
                (kursunsuz95 * litre95) +
                (kursunsuz97 * litre97) +
                (eurodizel10 * litreDizel) +
                (yeniprodizel * litreYeniDizel) +
                (gaz * litreGaz);

            // Kasadaki miktarı kontrol et
            baglanti.Open();
            SqlCommand kasaKontrol = new SqlCommand("SELECT MIKTAR FROM TBLKASA", baglanti);
            double kasaMiktar = Convert.ToDouble(kasaKontrol.ExecuteScalar());
            baglanti.Close();

            if (toplam > kasaMiktar)
            {
                MessageBox.Show("Kasada yeterli para yok! İşlem gerçekleştirilemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            //Kasa Güncelleme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", toplam);
            komut2.ExecuteNonQuery();

            baglanti.Close();
            //Kasa label güncelleme
            lblkasa.Text = (Convert.ToDouble(lblkasa.Text) - toplam).ToString();

            //Depo Güncelleme
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR='Kurşunsuz95'", baglanti);
            komut3.Parameters.AddWithValue("@p1", litre95);
            komut3.ExecuteNonQuery();
            progressBar1.Value = Convert.ToInt32(kursunsuz95alıslitre.Text);
            progressBar1.Refresh();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR='Kurşunsuz97'", baglanti);
            komut4.Parameters.AddWithValue("@p1", litre97);
            komut4.ExecuteNonQuery();
            progressBar2.Value = Convert.ToInt32(kursunsuz97alıslitre.Text);
            progressBar2.Refresh();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR='EuroDizel10'", baglanti);
            komut5.Parameters.AddWithValue("@p1", litreDizel);
            komut5.ExecuteNonQuery();
            progressBar3.Value = Convert.ToInt32(eurodizel10alıslitre.Text);
            progressBar3.Refresh();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR='YeniProDizel'", baglanti);
            komut6.Parameters.AddWithValue("@p1", litreYeniDizel);
            komut6.ExecuteNonQuery();
            progressBar4.Value = Convert.ToInt32(yeniprodizelalıslitre.Text);
            progressBar4.Refresh();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("update TBLBENZIN set STOK=STOK+@p1 where PETROLTUR='Gaz'", baglanti);
            komut7.Parameters.AddWithValue("@p1", litreGaz);
            komut7.ExecuteNonQuery();
            progressBar5.Value = Convert.ToInt32(gazalıslitre.Text);
            progressBar5.Refresh();
            baglanti.Close();
            MessageBox.Show("Alım İşlemi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fiyatListele(); 

        }
    }
}
