using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._4
{
    internal class Calculator
    {
        public static void CalculateInterest(ICalculateInterest calculateInterest, IAccount account)
        {
            calculateInterest.CalculateInterest(account);            
        }
    }
}
