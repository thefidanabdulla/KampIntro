using System;

namespace KampIntro
{
    class Program
    {  
        static void Main(string[] args)
        {
            //type safety
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 2500;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }

            if (sistemeGirisYapmismi == true) 
            {
                Console.WriteLine("Kullanici Ayarlari Buttonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Buttonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
