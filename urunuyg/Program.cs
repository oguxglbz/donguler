using System;

namespace urunuyg
{



    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.UrunAdi = "Kitap";
            urun1.UrunFiyati = 145;

            Urunler urun2 = new Urunler();
            urun2.UrunAdi = "Vazo";
            urun2.UrunFiyati = 120;

            Urunler urun3 = new Urunler();
            urun3.UrunAdi = "Masa";
            urun3.UrunFiyati = 150;

            Urunler urun4 = new Urunler();
            urun4.UrunAdi = "Bardak";
            urun4.UrunFiyati = 50;

            Urunler urun5 = new Urunler();
            urun5.UrunAdi = "Ayraç";
            urun5.UrunFiyati = 10;

            Urunler urun6 = new Urunler();
            urun6.UrunAdi = "Mouse";
            urun6.UrunFiyati = 130;

            Urunler urun7 = new Urunler();
            urun7.UrunAdi = "Kalem";
            urun7.UrunFiyati = 30;

            Urunler urun8 = new Urunler();
            urun8.UrunAdi = "Resim";
            urun8.UrunFiyati = 95;

            Urunler urun9 = new Urunler();
            urun9.UrunAdi = "Model Araba";
            urun9.UrunFiyati = 110;

            Urunler urun10 = new Urunler();
            urun10.UrunAdi = "Kulaklık";
            urun10.UrunFiyati = 55;

            if (urun1.UrunFiyati < 100)
            {
                Console.WriteLine(urun1);
            }
            if (urun2.UrunFiyati < 100)
            {
                Console.WriteLine(urun2);
            }
            if (urun3.UrunFiyati < 100)
            {
                Console.WriteLine(urun3);
            }
            if (urun4.UrunFiyati < 100)
            {
                Console.WriteLine(urun4);
            }
            if (urun5.UrunFiyati < 100)
            {
                Console.WriteLine(urun5);
            }
            if (urun6.UrunFiyati < 100)
            {
                Console.WriteLine(urun6);
            }
            if (urun7.UrunFiyati < 100)
            {
                Console.WriteLine(urun7);
            }
            if (urun8.UrunFiyati < 100)
            {
                Console.WriteLine(urun8);
            }
            if (urun9.UrunFiyati < 100)
            {
                Console.WriteLine(urun9);
            }
            if (urun10.UrunFiyati < 100)
            {
                Console.WriteLine(urun10);
            }


            Urunler[] urun = new Urunler[] { urun1, urun2, urun3, urun4, urun5, urun6, urun7, urun8, urun9, urun10 };
        }





            class Urunler
        {
            public string UrunAdi { get; set; }

            public int UrunFiyati { get; set; }

        }
    }
}
