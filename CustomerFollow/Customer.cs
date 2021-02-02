using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerFollow
{
    class Customer
    {
        public int Id { get; set; }

        private string _firtsName;
        public string Name { //ecapsulation 
            get { return "Mr." + _firtsName; } 
            set { _firtsName = value; } 
        }
        public string Surname { get; set; }
        public double Debt { get; set; }
    }
}