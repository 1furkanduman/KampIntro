using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Furkan Duman
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 2;
            musteri1.MusteriNo = "12344";
            musteri1.FirstName = "Furkan";
            musteri1.LastName = "Duman";

            //Duman Lojistik
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 3;
            musteri2.MusteriNo = "233434";
            musteri2.SirketAdi = "Duman Lojistik";
            musteri2.VergiNo = "23323232323";





            // Gerçek Müşteri - Tüzel Müşteri 
            // SOLID - Yazılım Geliştirme Prensibi

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);

        }
    }
}
