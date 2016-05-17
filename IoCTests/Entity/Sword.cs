using IoC.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Tests.Entity
{
    [AutoInject(typeof(IWeapon))]
    class Sword : IWeapon
    {
        public string Name
        {
            get
            {
                return "sword";
            }
        }

        public Sword()
        { }
    }
}
