using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._4
{
    internal class CalculateSalary : ICalculateInterest
    {
        public void CalculateInterest(IAccount account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
