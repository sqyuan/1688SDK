using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.util;

namespace _1688openapisdk.response.userdefinecategory
{
    public class UserCategoryGetOfferIdsResponse:AliResponse
    {
        public Dictionary<string, string[]> toReturn
        {
            get
            {
                return StringToIntArrayDictionary(this.body);

            }
        }

        public static Dictionary<string, string[]> StringToIntArrayDictionary(string body)
        {
            body = body.Replace("],", ";").Replace("]}", "");
            string[] kvs = body.Substring(1, body.Length - 1).Split(';');
            if (kvs == null)
                return null;
            Dictionary<string, string[]> ret = new Dictionary<string, string[]>();
            foreach (string kv in kvs)
            {
                string[] item = kv.Split(':');
                String[] ids = item[1].Substring(1, item[1].Length-1).Split(',');
                ret.Add(item[0].Substring(1, item[0].Length - 1), ids);
            }
            return ret;
        }
    }
}
