using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Credit payment plan was calculated");
        }
    }
}
