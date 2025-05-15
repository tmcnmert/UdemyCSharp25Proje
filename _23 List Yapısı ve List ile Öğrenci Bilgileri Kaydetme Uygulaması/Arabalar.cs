using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_List_Yapısı_ve_List_ile_Öğrenci_Bilgileri_Kaydetme_Uygulaması
{
     class Arabalar
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int Yil { get; set; }


        public Arabalar(string marka, string model, string renk, int yil)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            Yil = yil;
        }


    }
}
