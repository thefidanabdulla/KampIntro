using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DataBaseLoggerService : ILogggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
}
