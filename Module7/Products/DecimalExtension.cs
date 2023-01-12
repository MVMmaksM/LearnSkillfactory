using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Products
{
    internal static class DecimalExtension
    {
        public static void ToDiscount(this ref decimal price, int percent)
        {
            price = price * percent;
        }
    }
}
