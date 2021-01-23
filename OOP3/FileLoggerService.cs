using System;

namespace OOP3
{
    class FileLoggerService : ILOggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
}
