using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DataBaseLoggerService : ILOggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
}
