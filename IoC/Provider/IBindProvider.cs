using System;
using System.Collections.Generic;

namespace IoC.Provider
{
    public interface IBindProvider
    {
        List<KeyValuePair<Type, Type>> GetTypesNeedBinding(object parameter);
    }
}