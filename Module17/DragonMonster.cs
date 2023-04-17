using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    internal class DragonMonster : IMonsterFactory
    {
        public IMovement CreateMovement() => new FlyMovement();
        public IWeapon CreateWeapon() => new FireBreath();
    }
}
