using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Sınıf_Üzerinden_Veri_Tabanı_İşlemleri__OOP__Database_
{
    public class Kitap
    {
        int id;
        string ad;
        string yazar;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }
        public string YAZAR
        {
            get { return yazar; }
            set { yazar = value; }
        }



    }
}
