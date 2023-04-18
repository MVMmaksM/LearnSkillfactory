using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._4
{
    internal interface IAccount
    {
        // тип учетной записи
        string? Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }
        
        // процентная ставка
        public double Interes { get; set; }
    }
}
