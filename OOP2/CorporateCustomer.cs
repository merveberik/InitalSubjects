using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //miras: inheritance  corporate customer is a customer
    class CorporateCustomer :Customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
