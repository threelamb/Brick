using System;
using System.Security.Cryptography;
using System.Text;

namespace One.Common
{
    public class HashHelper
    {
        public static byte[] CalcMD5Hash(byte[] input)
        {
            MD5 md5 = MD5.Create();
            return md5.ComputeHash(input);
        }

        public static string CalcMD5Hash(string input)
        {
            byte[] en = CalcMD5Hash(Encoding.UTF8.GetBytes(input));
            return BitConverter.ToString(en).Replace("-", "").ToLower();
        }
    }
}
