using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Attribute
{
    /// <summary>
    /// Ignore property with this attribute when reflecting.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ReflectIgnoreAttribute : System.Attribute
    {
        public ReflectIgnoreAttribute(bool isIgnore = true)
        {
            Ignore = isIgnore;
        }

        public bool Ignore { get; set; }
    }
}
