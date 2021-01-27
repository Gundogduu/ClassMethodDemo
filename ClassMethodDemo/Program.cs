using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Cinsiyet = "Erkek";
            musteri1.Adi = "Hayri";
            musteri1.Soyadi = "Gündoğdu";
            musteri1.Sehir = "İstanbul";
            musteri1.Yas = 25;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Cinsiyet = "Erkek";
            musteri2.Adi = "Abdullah";
            musteri2.Soyadi = "Harezmi";
            musteri2.Sehir = "Erzurum";
            musteri2.Yas = 34;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Cinsiyet = "Erkek";
            musteri3.Adi = "Mustafa";
            musteri3.Soyadi = "Demirci";
            musteri3.Sehir = "Konya";
            musteri3.Yas = 28;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Cinsiyet = "Kadın";
            musteri4.Adi = "Özge";
            musteri4.Soyadi = "Ülkü";
            musteri4.Sehir = "İstanbul";
            musteri4.Yas = 27;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Cinsiyet = "Erkek";
            musteri5.Adi = "Kemal";
            musteri5.Soyadi = "Poyraz";
            musteri5.Sehir = "Hakkari";
            musteri5.Yas = 20;


            MusteriManager manager = new MusteriManager();
            manager.Ekle(musteri1);
            manager.Ekle(musteri2);
            manager.Ekle(musteri3);
            manager.Ekle(musteri4);
            manager.Ekle(musteri5);
            Console.WriteLine("------Müşteri Listesi--------");
            manager.Listele(musteri1, musteri2, musteri3, musteri4, musteri5);
            manager.Sil(musteri2);
            manager.Guncelle(musteri3);
            

            Console.ReadLine();


        }
    }
}
