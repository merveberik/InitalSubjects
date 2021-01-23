using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNo = "123456";
            customer1.FirstName = "Merve";
            customer1.LastName = "Berik";
            customer1.TcNo = "123456789";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CustomerId = 2;
            customer2.CustomerNo = "456123";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "123456789123";

            //Gerçek Müşteri - Tüzel Müşteri

            Customer customer3 = new CorporateCustomer(); //ref no - new
            Customer customer4 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            //if you have a base class. this is a reference catch 

        }
    }
}
