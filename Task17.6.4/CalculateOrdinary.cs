using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._4
{
    internal class CalculateOrdinary : ICalculateInterest
    {
        public void CalculateInterest(IAccount account)
        {
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
