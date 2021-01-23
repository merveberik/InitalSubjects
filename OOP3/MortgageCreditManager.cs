using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCreditManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Credit payment plan was calculated");
        }
    }
}
