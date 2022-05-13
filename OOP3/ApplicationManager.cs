using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeAnApp(ICreditManager creditManager, List<ILogggerService> logggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerservice in logggerServices)
            {
                loggerservice.Log();
            }
        }

        public void CreditPreliminaryInformation( List<ICreditManager> credits )
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
