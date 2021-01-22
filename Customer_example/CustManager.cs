using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_example
{
    class CustManager
    {
        public void Add(Cust cust)
        {
            Console.WriteLine("Customer Added: " + cust.Name + " " + cust.Surname);
        }
    }
}
