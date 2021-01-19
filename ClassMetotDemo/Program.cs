﻿using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ayşe";
            musteri1.Soyad = "Gümüş";
            musteri1.yas = 24;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Demir";
            musteri2.yas = 33;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Zeynep";
            musteri3.Soyad = "Altın";
            musteri3.yas = 18;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.yas);
                Console.WriteLine("- - - - - - -");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriSil(musteri3);


        }
    }
}
