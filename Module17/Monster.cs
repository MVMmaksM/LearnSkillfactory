using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    internal class Monster
    {
        private IWeapon _weapon;
        private IMovement _movement;
        public Monster(IMonsterFactory factory) 
        { 
            _movement= factory.CreateMovement();
            _weapon= factory.CreateWeapon();
        }

        public void Attack() => _weapon.Attack();
        public void Start()=> _movement.Start();
    }
}
