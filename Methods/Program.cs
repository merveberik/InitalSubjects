using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Sulu Karpuz";

            Product[] products = new Product[] { product1, product2 };

            //type-safe -- tip güvenliği
            foreach (Product product  in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("--------Metotlar--------");

            //instance -- örnek
            //ecapsulation  --  düzensizz olacak şeyleri düzene sokmaktır.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            //bu kullanım doğru değil zorlar
            sepetManager.Add2("Armut", "Yeşil Armut", 12);
            sepetManager.Add2("Elma", "Yeşil Elma", 12);



            Console.WriteLine("Hello World!");
        }
    }
}

///Dont repeat yourself - DRY - Clean Code - Best Practice
