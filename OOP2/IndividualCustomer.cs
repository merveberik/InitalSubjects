using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //individual customer is a customer
    //everything of customer is accept individual customer's
    class IndividualCustomer:Customer
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
