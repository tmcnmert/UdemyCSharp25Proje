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

namespace _22RssİleHaberBaslıkCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void habergetir(string url)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader(url);
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }   
        private void button3_Click(object sender, EventArgs e)
        {
            habergetir("http://www.hurriyet.com.tr/rss/anasayfa");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            habergetir("http://www.milatgazetesi.com/rss.php");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            habergetir("https://www.fotomac.com.tr/rss/anasayfa.xml");
        }
    }
}
