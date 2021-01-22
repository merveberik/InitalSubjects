using DictionaryHomework;
using System;
using System.Collections.Generic;

namespace GenericsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();

            Ogrenci.Add(123, "Lale");
            Ogrenci.Add(456, "Elif");

            Console.WriteLine(Ogrenci.Count);

            MyDictionary<int, string> ogrenciler2 = new MyDictionary<int, string>();
            ogrenciler2.Add(159, "Merve");
            ogrenciler2.Add(753, "Ahmet");
            ogrenciler2.Add(456, "Ayşe");
            ogrenciler2.Add(789, "Ela");

            Console.WriteLine(ogrenciler2.Count);



        }
    }
}
