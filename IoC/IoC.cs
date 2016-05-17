using IoC.Provider;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class IoC
    {
        private static readonly StandardKernel kernel;
        private static readonly IBindProvider bindProvider;
        static IoC()
        {
            kernel = new StandardKernel();
            bindProvider = new DefaultBindProvider();
        }

        public static void Initialize()
        {
            Initialize(bindProvider, Assembly.GetCallingAssembly());
        }

        public static void Initialize(IBindProvider bindProvider, object para)
        {
            List<KeyValuePair<Type, Type>> mapping;

            mapping = bindProvider.GetTypesNeedBinding(para);
            if (mapping != null && mapping.Count > 0)
            {
                foreach (var item in mapping)
                {
                    kernel.Bind(item.Key, item.Value).To(item.Value);
                }
            }
        }

        public static T New<T>()
        {
            return kernel.Get<T>();
        }
    }
}
