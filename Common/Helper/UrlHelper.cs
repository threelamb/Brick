using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace One.Common
{
    public class UrlHelper
    {
        public static string ConvertToUrl<T>(string url, T request)
          where T : class
        {
            SortedDictionary<string, string> sortedParameters = request.PropertiesToSortDic<T>();

            Encoding encode = Encoding.GetEncoding("utf-8");
            string paraEncoded = CreateLinkStringUrlencode(sortedParameters, encode);
            string res = string.Format("{0}?{1}", url, paraEncoded);

            return res;
        }

        /// <summary>
        /// 把数组所有元素，按照“参数=参数值”的模式用“&”字符拼接成字符串，并对参数值做urlencode
        /// </summary>
        /// <param name="sArray">需要拼接的数组</param>
        /// <param name="code">字符编码</param>
        /// <returns>拼接完成以后的字符串</returns>
        public static string CreateLinkStringUrlencode(SortedDictionary<string, string> dicArray, Encoding code)
        {
            StringBuilder prestr = new StringBuilder();
            foreach (KeyValuePair<string, string> temp in dicArray)
            {
                prestr.Append(temp.Key + "=" + HttpUtility.UrlEncode(temp.Value, code) + "&");
            }

            //去掉最後一個&字符
            int nLen = prestr.Length;
            prestr.Remove(nLen - 1, 1);

            return prestr.ToString();
        }
    }
}
