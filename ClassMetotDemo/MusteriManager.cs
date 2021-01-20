using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
         Console.WriteLine("Tebrikler Müşteri Kayıdı Eklendi" );
         Console.WriteLine("Musteri Id" + musteri.MusteriId);
         Console.WriteLine("Musteri Adı" + musteri.MusteriAdi );
         Console.WriteLine("Musteri Soyadı" + musteri.MusteriSoyadi );
         Console.WriteLine("Hesap Tarihi" + musteri.HesapTarihi );
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Kayıdı Silindi");
            Console.WriteLine("Musteri Id" + musteri.MusteriId);
            Console.WriteLine("Musteri Adı" + musteri.MusteriAdi);
            Console.WriteLine("Musteri Soyadı" + musteri.MusteriSoyadi);
            Console.WriteLine("Hesap Tarihi" + musteri.HesapTarihi);
        }

        public void MusteriListele(Musteri musteri) 
        {
            Console.WriteLine("Tebrikler Müşteri Kayıdı Listelendi");
            Console.WriteLine("Musteri Id" + musteri.MusteriId);
            Console.WriteLine("Müsteri Adı" + musteri.MusteriAdi);
            Console.WriteLine("Müsteri Soyadı" + musteri.MusteriSoyadi);
            Console.WriteLine("Hesap Tarihi" + musteri.HesapTarihi);
        }
    }
}
