using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerCreditManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer Credit payment plan was calculated");
        }
    }
}
