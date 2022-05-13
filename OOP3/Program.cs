using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager residenceCreditManager = new ResidenceCreditManager();
            ICreditManager tradesmanCreditManager = new TradesmanCredit();

            ILogggerService databaseLoggerService = new DataBaseLoggerService();
            ILogggerService fileLoggerService = new FileLoggerService();
            ILogggerService smsService = new SmsLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApp(tradesmanCreditManager, new List<ILogggerService> { databaseLoggerService, smsService });

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCredit, vehicleCreditManager } ;

            //applicationManager.CreditPreliminaryInformation(credits);

        }
    }
}
