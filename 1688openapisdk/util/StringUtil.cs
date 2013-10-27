using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.util
{
    public class StringUtil
    {
        public static Dictionary<string, int> StringToDictionary(string body)
        {
            string[] kvs = body.Replace('\\', ' ').Replace('"', ' ').Substring(1, body.Length - 2).Split(',');
            if (kvs == null)
                return null;
            Dictionary<string, int> ret = new Dictionary<string, int>();
            foreach (string kv in kvs)
            {
                string[] item = kv.Split(':');
                ret.Add(item[0].Substring(1, item[0].Length - 1), int.Parse(item[1]));
            }
            return ret;
        }
    }
}
