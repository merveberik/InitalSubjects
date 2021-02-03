using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    internal class ProgramBase
    {
    }

    internal class ProgramBase1
    {
    }

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
            // Test(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products); 

            //AscDescTest(products); 

            //ClassicLinqTest(products); 

            var result = from p in products join c in categories  //categoryId ye göre joinleme yapacağız  
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice>5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategaryName, ProductName=p.ProductName, UnitPrice=p.UnitPrice};
            foreach (var productDto in result)  //resulttaki her bir productdto için
            {
                Console.WriteLine("{0} --- {1} ",productDto.ProductName , productDto.CategoryName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products  //her bir p den aldığımız products listesi içinde
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending //orderby p.UnitPrice   //küçükten büyüğe sıralıyor 
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };  //select p;  //uygun olanları alırız
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Asus Laptop");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik---------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
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

    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
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
