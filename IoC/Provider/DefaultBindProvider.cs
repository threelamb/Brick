using IoC.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Provider
{
    class DefaultBindProvider : IBindProvider
    {
        public List<KeyValuePair<Type, Type>> GetTypesNeedBinding(object parameter)
        {
            List<KeyValuePair<Type, Type>> result = null;
            KeyValuePair<Type, Type> resultItem;
            Assembly targetAssembly;
            AssemblyName[] targetReferenceAssemblyNames;
            List<Assembly> targetAssemblies = null;
            List<Type> needBindTypes = null;
            AutoInjectAttribute attribute;

            targetAssembly = parameter as Assembly;
            if (targetAssembly != null)
            {
                targetReferenceAssemblyNames = targetAssembly.GetReferencedAssemblies();
                targetAssemblies = new List<Assembly>();
                targetAssemblies.Add(targetAssembly);
                if (targetReferenceAssemblyNames != null && targetReferenceAssemblyNames.Length > 0)
                {

                    foreach (var item in targetReferenceAssemblyNames)
                    {
                        var tempAssembly = Assembly.Load(item);
                        if (tempAssembly != null)
                        {
                            targetAssemblies.Add(tempAssembly);
                        }
                    }
                }

                if (targetAssemblies != null && targetAssemblies.Count > 0)
                {
                    needBindTypes = new List<Type>();
                    foreach (var item in targetAssemblies)
                    {
                        var tempTypes = item.GetTypes().ToList();
                        tempTypes = tempTypes.FindAll(o => o.GetCustomAttribute<AutoInjectAttribute>() != null);
                        if (tempTypes != null && tempTypes.Count > 0)
                        {
                            needBindTypes.AddRange(tempTypes);
                        }
                    }
                }

                if (needBindTypes != null && needBindTypes.Count > 0)
                {
                    result = new List<KeyValuePair<Type, Type>>();
                    foreach (var item in needBindTypes)
                    {
                        attribute = item.GetCustomAttribute<AutoInjectAttribute>();
                        resultItem = new KeyValuePair<Type, Type>(attribute.Type, item);
                        result.Add(resultItem);
                    }
                }
            }

            return result;
        }
    }
}
