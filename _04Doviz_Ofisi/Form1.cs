using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace _04Doviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=DovizOfisiDB;Integrated Security = True;TrustServerCertificate=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya= new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolaralis.Text = dolaralis;
            lbldolarsatis.Text = dolarsatis;
            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleuroal.Text = euroalis;
            lbleurosat.Text = eurosatis;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleuroal.Text;
        }

        private void btndolaral_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolaralis.Text;
        }

        private void tndolarsat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsatis.Text;
        }

        private void btneurosat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleurosat.Text;
        }

        private void btnsatısyap_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtkur.Text);
            miktar = Convert.ToDouble(txtmiktar.Text);
            tutar = kur * miktar;
            txttutar.Text = tutar.ToString();
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ",");
        }

        private void btnsatısyap2_Click(object sender, EventArgs e)
        {
            double kur=Convert.ToDouble(txtkur.Text);
            int miktar = Convert.ToInt32(txtmiktar.Text);
            int tutar = Convert.ToInt32(miktar/kur);
            double kalan; 
            kalan = miktar % kur;
            txtkalan.Text = tutar.ToString();

        }

        private void btndolaral_Click_1(object sender, EventArgs e)
        {
            txtkur.Text = lbldolaralis.Text;
        }

        private void tndolarsat_Click_1(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsatis.Text;
        }

        private void btneuroal_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleuroal.Text;
        }

        private void btneurosat_Click_1(object sender, EventArgs e)
        {
            txtkur.Text = lbleurosat.Text;
        }

        private void txtkur_TextChanged_1(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ",");
        }

        private void btnHareketleriGoster_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            baglanti.Open();
            SqlDataAdapter dr = new SqlDataAdapter("SELECT DovizKodu, Miktar FROM KasaBakiye", baglanti);
            dr.Fill(dt);
            baglanti.Close();

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Döviz Kodu";
            dataGridView1.Columns[1].HeaderText = "Miktar";
        }
    }
}
