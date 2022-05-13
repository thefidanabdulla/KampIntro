using System;

namespace OOP3
{
    class FileLoggerService : ILogggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
}
