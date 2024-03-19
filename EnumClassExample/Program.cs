using System;

namespace EnumClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri(1, "Enes", "Bayram", "Erkek", "enes.bayram@gmail.com");

            MusteriDurum donenDurum = musteri.musteriEkle(musteri);

            if(donenDurum == MusteriDurum.kayitBasarili)
            {
                Console.WriteLine("Müşteri başarılı bir şekilde eklenmiştir.");
            }

            Console.ReadLine();
        }
    }
}
