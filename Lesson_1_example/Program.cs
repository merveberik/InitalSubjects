using System;

namespace Lesson_1_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //kategoriEtiketi -> değer tutucui alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");

            }

            if (sistemeGirisYapmismi == true) //if yazıp 2 kez taba basarsak parantezler oluşur
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else //2 tab yap
            {
                Console.WriteLine("Giriş Yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
      
        }
    }
}
