using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Oguz";
            int yas = 15;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.Izlenme = "68";


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.Izlenme = "66";


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.Izlenme = "85";

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var Kurs in kurslar)
            {
                Console.WriteLine(Kurs.KursAdi + " : " + kurs1.Egitmen);
            }
        }




        class Kurs
        {
            public string KursAdi { get; set; }

            public string Egitmen { get; set; }

            public string Izlenme { get; set; }

        }
    }
    }

