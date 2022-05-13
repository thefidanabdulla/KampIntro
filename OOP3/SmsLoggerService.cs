using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerService : ILogggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms sent");
        }
    }
}
