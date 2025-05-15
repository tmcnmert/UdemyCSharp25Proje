using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_List_Yapısı_ve_List_ile_Öğrenci_Bilgileri_Kaydetme_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlistele1_Click(object sender, EventArgs e)
        {
            List<string> kisiler = new List<string>();
            kisiler.Add("Ayşe");
            kisiler.Add("Mehmet");
            kisiler.Add("Fatma");
            kisiler.Add("Zeynep");
            kisiler.Add("Emre");
            kisiler.Add("Elif");
            kisiler.Add("Deniz");
            kisiler.Add("Cem");
            kisiler.Add("Seda");
            kisiler.Add("Derya");
            kisiler.Add("Merve");
            kisiler.Add("Sıla");
            kisiler.Add("Eylül");
            kisiler.Add("Ceren");
            kisiler.Add("Gizem");
            kisiler.Add("Seda");
            kisiler.Add("Seda");

            // kisiler.Remove("Seda");

            foreach (string k in kisiler)
            {
                listBox1.Items.Add(k);
            }

        }

        private void btnlistele2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(6);
            sayilar.Add(7);
            sayilar.Add(8);
            sayilar.Add(9);
            sayilar.Add(10);


            //foreach (int s in sayilar)
            //{
            //    if (s % 5 == 0)
            //    {
            //        listBox2.Items.Add(s);
            //    }
            //}

            if (sayilar.Contains(int.Parse(textBox1.Text)))
            {
                MessageBox.Show("Sayı listede var");
            }
            else
            {
                MessageBox.Show("Sayı listede yok");
            }
        }

        private void btnlistele3_Click(object sender, EventArgs e)
        {
            List<kisiler> kisi = new List<kisiler>();

            kisi.Add(new kisiler("Ayşe", "Yılmaz", "Öğretmen"));
            kisi.Add(new kisiler("Mehmet", "Demir", "Mühendis"));


            foreach (kisiler k in kisi)
            {
                listBox3.Items.Add(k.Ad + " " + k.Soyad + " " + k.Meslek);
            }
        }

        private void btnlistele4_Click(object sender, EventArgs e)
        {
            List<Arabalar> arabalar = new List<Arabalar>();
            arabalar.Add(new Arabalar("BMW", "X5", "Beyaz", 2020));
            arabalar.Add(new Arabalar("Mercedes", "C180", "Siyah", 2021));
            arabalar.Add(new Arabalar("Audi", "A4", "Kırmızı", 2019));
            arabalar.Add(new Arabalar("Hyundai", "i20", "Beyaz", 2017));
            arabalar.Add(new Arabalar("Chevrolet", "Cruze", "Kırmızı", 2020));
            arabalar.Add(new Arabalar("Mazda", "3", "Yeşil", 2019));
            arabalar.Add(new Arabalar("Land Rover", "Range Rover", "Siyah", 2022));
            arabalar.Add(new Arabalar("Jaguar", "F-Pace", "Kırmızı", 2020));
            arabalar.Add(new Arabalar("Porsche", "Macan", "Mavi", 2021));
            arabalar.Add(new Arabalar("Tesla", "Model 3", "Yeşil", 2019));
            arabalar.Add(new Arabalar("Volvo", "XC60", "Siyah", 2022));

            foreach (Arabalar a in arabalar)
            {
                listBox4.Items.Add(a.Marka + " " + a.Model + " " + a.Renk + " " + a.Yil);
            }
        }
    }
}
