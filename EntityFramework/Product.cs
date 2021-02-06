using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class Product
    {
        public int ProductId { get; set; } //primary key
        public int CategoryId { get; set; } //Foreign key
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        //public decimal UnitPrice { get; set; }
        //public short UnitStock { get; set; }


    }
}
