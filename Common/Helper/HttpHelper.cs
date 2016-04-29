using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace One.Common
{
    public class HttpHelper
    {
        public static string Get(string strUrl)
        {
            string strResult;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(strUrl);
                HttpWebResponse httpWResp = (HttpWebResponse)req.GetResponse();
                Stream stream = httpWResp.GetResponseStream();
                StreamReader sr = new StreamReader(stream, Encoding.Default);
                StringBuilder strBuilder = new StringBuilder();
                while (-1 != sr.Peek())
                {
                    strBuilder.Append(sr.ReadLine());
                }

                strResult = strBuilder.ToString();
            }
            catch (Exception exp)
            {
                strResult = "错误：" + exp.Message;
            }

            return strResult;
        }

        public static byte[] GetByte(string strUrl)
        {
            byte[] result;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(strUrl);
                HttpWebResponse httpWResp = (HttpWebResponse)req.GetResponse();
                Stream stream = httpWResp.GetResponseStream();
                result = TypeHelper.StreamToBytes(stream);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T Get<T>(string strUrl)
        {
            try
            {
                return JsonHelper.Deserialize<T>(Get(strUrl));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
