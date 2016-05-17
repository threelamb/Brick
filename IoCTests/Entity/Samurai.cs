using IoC.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Tests.Entity
{
    [AutoInject(typeof(IWarrior))]
    class Samurai : IWarrior
    {
        public IWeapon _weapon;
        private string _name = null;

        public IWeapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public Samurai(IWeapon weapon)
        {
            Weapon = weapon;
        }
    }
}
