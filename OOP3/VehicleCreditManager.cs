using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calculating the payment schedule of a Vehicle credit");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
