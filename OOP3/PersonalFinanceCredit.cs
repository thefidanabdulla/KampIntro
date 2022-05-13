using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calculating the payment schedule of a Personal Finance credit");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
