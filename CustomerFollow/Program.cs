using System;

namespace CustomerFollow
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 987456;
            customer1.Name = "Merve";
            customer1.Surname = "Berik";
            customer1.Debt = 1200;

            Customer customer2 = new Customer();
            customer2.Id = 321654;
            customer2.Name = "Emir";
            customer2.Surname = "Demir";
            customer2.Debt = 1500;

            Customer customer3 = new Customer();
            customer3.Id = 741258;
            customer3.Name = "Mualla";
            customer3.Surname = "Öz";
            customer3.Debt = 2020;


            Customer[] customer = new Customer[] { customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("This customers Added:");
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("----------------");
            customerManager.List(customer);
            Console.WriteLine("This customers Deleted:");
            customerManager.Delete(customer3);

        }
    }
}
