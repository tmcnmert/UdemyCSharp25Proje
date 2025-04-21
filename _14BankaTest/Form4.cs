using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14BankaTest
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void Form4_Load(object sender, EventArgs e)
        {
            //hesaba giriş
            SqlDataAdapter da = new SqlDataAdapter("Select (AD+' '+SOYAD) as 'Gönderen',TUTAR from TBLHAREKET inner join Tblkisiler on TBLHAREKET.GONDEREN=TblKisiler.HESAPNO", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //hesaptan çıkış

            SqlDataAdapter da2 = new SqlDataAdapter("Select (AD+' '+SOYAD) as 'Alıcı',TUTAR from TBLHAREKET inner join Tblkisiler on TBLHAREKET.ALICI=TblKisiler.HESAPNO", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            
        }
    }
}
