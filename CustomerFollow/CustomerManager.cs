using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerFollow
{
    class CustomerManager
    { 
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added: " + customer.Name + " " + customer.Surname);
        }
        public void List(Customer[] customers)
        {
            foreach (var cust in customers)
            {
                Console.WriteLine("Id Number:" + cust.Id);
                Console.WriteLine("Name Surname:" + cust.Name +" "+ cust.Surname);
                Console.WriteLine("Debt:" + cust.Debt);
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted this customer:" + customer.Name + " " + customer.Surname);
        }
    }
}
