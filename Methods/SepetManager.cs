using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Add(Product product)       //method is working here     // ne ekleyeceğimizi product olarak yazıyoruz ne ekleyeceksek parametre olarak
        {
            Console.WriteLine("Sepete eklendi : " + product.Adi);

        }

        //bu şekilde kullanılmamalı -- buraya birşey eklersek stok adedi gibi ekranda programda tek tek eklemek gerekir.
        public void Add2(string productName, string Explain, double price)
        {
            Console.WriteLine("Sepetee eklendi : " + productName);
        }
    }
}
