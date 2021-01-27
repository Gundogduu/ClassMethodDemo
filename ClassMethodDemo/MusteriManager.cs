using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.Adi + " " + musteri.Soyadi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Adi + " " + musteri.Soyadi);
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri güncellendi: " + " " + musteri.Adi + musteri.Soyadi);
        }
        public void Listele(params Musteri[] musteriler)
        {
            foreach (Musteri kisi in musteriler)
            {
                Console.WriteLine(kisi.Adi + " " + kisi.Soyadi);
            }

            
        }
    }
}
