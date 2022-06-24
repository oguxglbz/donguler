using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım geliştirici yetiştirme kursu";
            string kurs2 = "Java kursu";
            string kurs3 = "C# kursu";


            //array - dizi
            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kursu", "Java kursu", "C# kursu" ,   "Python"};


            for (int i = 0;  i< kurslar.Length;  i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("Sayfa sonu- footer");
        }
    }
}
