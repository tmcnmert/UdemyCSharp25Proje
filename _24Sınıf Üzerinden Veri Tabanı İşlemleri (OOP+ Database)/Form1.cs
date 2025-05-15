using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24Sınıf_Üzerinden_Veri_Tabanı_İşlemleri__OOP__Database_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kitapvt vtsinif = new Kitapvt();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vtsinif.KitapListele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.ADI = textBox1.Text;
            kitap.YAZAR = textBox2.Text;
            vtsinif.kitapEkle(kitap);
            MessageBox.Show("Kitap eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Kitap kitap = new Kitap();
            kitap.ID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            vtsinif.kitapSil(kitap);
            MessageBox.Show("Kitap Silindi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Kitap kitap = new Kitap();
            kitap.ADI = textBox1.Text;
            kitap.YAZAR = textBox2.Text;
            kitap.ID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            vtsinif.kitapGuncelle(kitap);
            MessageBox.Show("Kitap Güncellendi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}
