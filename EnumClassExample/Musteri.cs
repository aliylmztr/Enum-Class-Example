using System.Collections;

namespace EnumClassExample
{
    public class Musteri
    {
        public int id;
        public string isim;
        public string soyisim;
        public string cinsiyet;
        public string emailAdres;

        public Musteri(int id, string isim, string soyisim, string cinsiyet, string emailAdres)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.cinsiyet = cinsiyet;
            this.emailAdres = emailAdres;
        }

        public static ArrayList musteriler = new ArrayList();

        public MusteriDurum musteriEkle(Musteri m1)
        {
            musteriler.Add(m1); // müşterimizi koleksiyona ekledik.

            return MusteriDurum.kayitBasarili;
        }
    }
}
