using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    internal class Axe : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Бить топором");
        }
    }
}
