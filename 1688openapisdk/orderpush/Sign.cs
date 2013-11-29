using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace _1688openapisdk.orderpush
{
    public class Sign
    {
        public static string sign(Dictionary<string, string> paramDic,string SecurityKey)
        {

            byte[] signatureKey = Encoding.UTF8.GetBytes(SecurityKey);//此处用自己的签名密钥
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> kv in paramDic)
            {
                if(kv.Key.ToLower()!="sign")
                    list.Add(kv.Key + kv.Value);
            }
            list.Sort();
            StringBuilder tmp = new StringBuilder();
            foreach (string kvstr in list)
            {
                tmp.Append(kvstr);
            }

            //HMAC-SHA1
            HMACSHA1 hmacsha1 = new HMACSHA1(signatureKey);
            hmacsha1.ComputeHash(Encoding.UTF8.GetBytes(tmp.ToString()));
            /*
            hmacsha1.ComputeHash(Encoding.UTF8.GetBytes(urlPath));
            foreach (string kvstr in list)
            {
                hmacsha1.ComputeHash(Encoding.UTF8.GetBytes(kvstr));
            }
             */
            byte[] hash = hmacsha1.Hash;
            //TO HEX
            return BitConverter.ToString(hash).Replace("-", string.Empty).ToUpper();
        }


        public static string signMD5(Dictionary<string, string> paramDic, string SecurityKey)
        {

            byte[] signatureKey = Encoding.UTF8.GetBytes(SecurityKey);//此处用自己的签名密钥
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> kv in paramDic)
            {
                if (kv.Key.ToLower() != "sign")
                    list.Add(kv.Key + kv.Value);
            }
            list.Sort();
            StringBuilder tmp = new StringBuilder();
            foreach (string kvstr in list)
            {
                tmp.Append(kvstr);
            }

            //HMAC-MD5
            HMACMD5 hmacmd5 = new HMACMD5(signatureKey);
            hmacmd5.ComputeHash(Encoding.UTF8.GetBytes(tmp.ToString()));
            /*
            hmacsha1.ComputeHash(Encoding.UTF8.GetBytes(urlPath));
            foreach (string kvstr in list)
            {
                hmacsha1.ComputeHash(Encoding.UTF8.GetBytes(kvstr));
            }
             */
            byte[] hash = hmacmd5.Hash;
            //TO HEX
            return BitConverter.ToString(hash).Replace("-", string.Empty).ToUpper();
        }
    }
}
