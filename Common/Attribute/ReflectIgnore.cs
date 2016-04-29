using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Common.Attribute
{
    /// <summary>
    /// Ignore property with this attribute when reflecting.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ReflectIgnore : System.Attribute
    {
        public ReflectIgnore(bool isIgnore = true)
        {
            Ignore = isIgnore;
        }

        public bool Ignore { get; set; }
    }
}
