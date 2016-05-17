using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Tests.Entity
{
    public interface IWarrior
    {
        IWeapon Weapon { get; }
    }
}
