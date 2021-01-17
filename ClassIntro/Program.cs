using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Course kurs1 = new Course();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin";
            kurs1.IzlenmeOrani = 69;

            Course kurs2 = new Course();
            kurs2.KursAdi = "Python";
            kurs2.KursEgitmeni = "Kerem";
            kurs2.IzlenmeOrani = 15;

            Course kurs3 = new Course();
            kurs3.KursAdi = "Java";
            kurs3.KursEgitmeni = "Berkay";
            kurs3.IzlenmeOrani = 8;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursEgitmeni);
            //ikincide course yerine string yazarsak string tutarız bu şekilde kursları tutacağız
            Course[] kurslar = new Course[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                //Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmeni);

            }

        }
    }

    class Course
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
