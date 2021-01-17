using System;

namespace ValueAndRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;  //stack içindedir bunlar
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30 

            //pointer olayıdır
            int[] sayilar1 = new int[] { 10, 20, 30 };  //new diyince bellekte yer açtık heap içinde
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;   //ref numarası denir  //gereksiz sayıları da çöp toplayıcı(destructor) toplar.
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999 olur

            //int, double, float, double, bool = değer tip
            //array, class, interface = referans tip
        }
    }
}
