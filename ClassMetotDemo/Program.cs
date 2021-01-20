using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Aydemir";
            musteri1.MusteriSoyadi = "Özcan";
            musteri1.HesapTarihi = 2015;


            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Engin";
            musteri2.MusteriSoyadi = "Demiroğ";
            musteri2.HesapTarihi = 2014;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Aziz";
            musteri3.MusteriSoyadi = "Sancar";
            musteri3.HesapTarihi = 2013;



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriId);
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.HesapTarihi);

            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriEkle(musteri3);

            musteriManager.MusteriListele(musteri1);

        }
    }
}
