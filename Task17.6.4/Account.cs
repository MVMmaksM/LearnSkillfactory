using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._4
{
    internal class Account : IAccount
    {
        public string? Type { get; set; }
        public double Balance { get; set; }
        public double Interes { get; set; }
    }
}
