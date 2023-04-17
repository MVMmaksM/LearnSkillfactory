using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    internal class OrcMonster : IMonsterFactory
    {
        public IMovement CreateMovement()=> new RunMovement();       
        public IWeapon CreateWeapon()=> new Axe();       
    }
}
