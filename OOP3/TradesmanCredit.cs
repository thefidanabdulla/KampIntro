using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TradesmanCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calculating the payment schedule of a Tradesman credit");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
