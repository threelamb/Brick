using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Common.Extensions
{
    public static class HtmlExtensions
    {
        public static String ToHtmlTable<T>(this T para)
        {
            string res;
            string value;
            StringBuilder sb = new StringBuilder();
            var dic = para.PropertiesToSortDic<T>();
            sb.Append(@"<Table>");
            foreach (var item in dic.Keys)
            {
                sb.Append(@"<tr>");
                sb.Append(@"<td>");
                dic.TryGetValue(item, out value);
                sb.Append(value);
                sb.Append(@"</td>");
                sb.Append(@"</tr>");
            }
            sb.Append(@"</Table>");
            res = sb.ToString();
            return res;
        }
    }
}
