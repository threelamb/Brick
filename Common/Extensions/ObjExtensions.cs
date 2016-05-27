using EmitMapper;
using One.Common.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace One.Common
{
    public static class ObjExtensions
    {
        public static string ToJson<T>(this T obj)
        {
            string res = string.Empty;

            if (obj != null)
            {
                res = JsonHelper.Serialize<T>(obj);
            }

            return res;
        }

        public static SortedDictionary<string, string> PropertiesToSortDic<T>(this T para)
        {
            SortedDictionary<string, string> sortDic;

            var propertyList = typeof(T).GetProperties().ToList();
            sortDic = new SortedDictionary<string, string>();
            if (para != null)
            {
                foreach (var item in propertyList)
                {
                    var reflectIgnoreAttr = item.GetCustomAttribute(typeof(ReflectIgnoreAttribute)) as ReflectIgnoreAttribute;
                    if (reflectIgnoreAttr != null && reflectIgnoreAttr.Ignore || item.GetValue(para) == null)
                    {
                        continue;
                    }
                    sortDic.Add(item.Name, item.GetValue(para).ToString());
                }
            }

            return sortDic;
        }


        #region Mapper
        /// <summary>
        /// Create Traget class type object and set its property value the same as the the property with the same name of Source type object.
        /// </summary>
        /// <typeparam name="Source">Source class type</typeparam>
        /// <typeparam name="Target">Target class type</typeparam>
        /// <param name="source">Source class type object</param>
        /// <returns></returns>
        public static Target Map<Source, Target>(this Source source)
            where Source : new()
            where Target : new()
        {
            if (source == null) return new Target();
            var mapper = ObjectMapperManager.DefaultInstance.GetMapper<Source, Target>();
            return mapper.Map(source);
        }
        #endregion 
    }
}
