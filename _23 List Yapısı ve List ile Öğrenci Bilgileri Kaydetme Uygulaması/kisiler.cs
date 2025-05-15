using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_List_Yapısı_ve_List_ile_Öğrenci_Bilgileri_Kaydetme_Uygulaması
{
     class kisiler
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Meslek { get; set; }

        public kisiler(string ad, string soyad, string meslek)
        {
            Ad = ad;
            Soyad = soyad;
            Meslek = meslek;
        }

    }
}
