using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategaryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategaryName = "Telefon"},
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName= "Acer Laptop", UnitPrice = 7000, UnitsInStock = 5},
                new Product{ProductId = 2, CategoryId = 1, ProductName= "Asus Laptop", UnitPrice = 8000, UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId = 2, ProductName= "Samsung Telefon", UnitPrice = 5000, UnitsInStock = 15},
                new Product{ProductId = 4, CategoryId = 2, ProductName= "Apple Telefon", UnitPrice = 8000, UnitsInStock = 0},
            };
            Console.WriteLine("Algoritmik---------------");
            foreach (var product in products)
            {
                if(product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("Linq---------------");
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }
            GetProducts(products);
        }
        static List<Product> GetProducts(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();  //where listeye atma yapıyor
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategaryName { get; set; }
    }
}
