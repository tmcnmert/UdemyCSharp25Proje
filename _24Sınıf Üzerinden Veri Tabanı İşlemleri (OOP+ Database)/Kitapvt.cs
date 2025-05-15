using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace _24Sınıf_Üzerinden_Veri_Tabanı_İşlemleri__OOP__Database_
{
    class Kitapvt
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\mert\\Desktop\\Yeni Microsoft Access Database1.accdb\"");

        public List<Kitap> KitapListele()
        {
            List<Kitap> kitaplar = new List<Kitap>();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kitaplar", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt32(dr[0]);
                k.ADI = dr[1].ToString();
                k.YAZAR = dr[2].ToString();
            }
            baglanti.Close();
            return kitaplar;
        }

        public void kitapEkle(Kitap kt)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KITAPAD,YAZAR) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", kt.ADI);
            komut.Parameters.AddWithValue("@p2", kt.YAZAR);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public void kitapSil(Kitap kt)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Kitaplar where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", kt.ID);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void kitapGuncelle(Kitap kt)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Kitaplar set KITAPAD=@p1, YAZAR=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", kt.ADI);
            komut.Parameters.AddWithValue("@p2", kt.YAZAR);
            komut.Parameters.AddWithValue("@p3", kt.ID);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
