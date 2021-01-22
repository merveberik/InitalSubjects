using System;

namespace Constructors
{
    //özellik barındıran constructor yapısı
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1 ,FirstName="Merve", LastName="Berik", City="Ankara"};//bunun kullanımı
            Customer customer3 = new Customer();//ve bunun kullanımı aynıdır
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "merve", "berik", "ankara"); //metoda yazmışız gibi
            Console.WriteLine(customer2.FirstName);
        }
   
    }

    class Customer
    {
        //bunu ekleyerek 2 kullanımı da açabildik customer1 ve customer3 için bu çalıştı
        public Customer()
        {

        }
        //default constructor //customer2 için bu çalıştı.
        public Customer(int id, string firstname, string lastname, string city)
        {
            //constructor cw yapmak için bu şekilde çağırırız. buraya set ederiz.
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
            //Console.WriteLine("Yapıcı blok çalıştı."); //new diyince bu blok çalışır.

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
