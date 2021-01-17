using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yerleştirme Kampı";
            string kurs2 = "Programlamaya başlangıç kursu";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            string[] kurslar = new string[] { "Yazılım Geliştirici Yerleştirme Kampı",
                "Programlamaya başlangıç kursu",
                "Java", "C#"};

            for (int i = 0; i < kurslar.Length; i++) //kurslar.Length boyutu neyse
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti"); 
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");

        }
    }
}
