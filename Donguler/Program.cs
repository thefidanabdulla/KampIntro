using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim gelistirici yetistirme kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //array

            string[] kurslar = new string[] {
                "Yazilim gelistirici yetistirme kampi",
                "Programlamaya baslangic icin temel kurs",
                "Java",
                "Python"
            };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
