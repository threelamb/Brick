using One.Common.Attribute;
using System.Collections.Generic;
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
                    var reflectIgnoreAttr = item.GetCustomAttribute(typeof(ReflectIgnore)) as ReflectIgnore;
                    if (reflectIgnoreAttr != null && reflectIgnoreAttr.Ignore || item.GetValue(para) == null)
                    {
                        continue;
                    }
                    sortDic.Add(item.Name, item.GetValue(para).ToString());
                }
            }

            return sortDic;
        }
    }
}
