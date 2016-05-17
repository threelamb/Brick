using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
    public class AutoInjectAttribute : System.Attribute
    {
        public AutoInjectAttribute(Type type)
        {
            Type = type;
        }

        public Type Type { get; set; }
    }
}
