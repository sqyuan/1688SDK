using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk
{
    class Program
    {
        static void Main(string[] args)
        {

            string loginUrl = "https://gw.open.1688.com/openapi/param2/1/system.oauth2/authn/" + Config.appKey;
            Encoding encoding = Encoding.GetEncoding("gb2312");

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("loginIdType", "LOGIN_ID");
            parameters.Add("needRefreshToken", "false");
            parameters.Add("account", Config.userName);
            parameters.Add("password", Config.password);
            string _aop_signature = Sign.sign("param2/1/system.oauth2/authn/338249", parameters, Config.appSecret);
            parameters.Add("_aop_signature",_aop_signature);

            /** 
            System.Net.HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, parameters, null, null, encoding, null);
            using (System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream(), System.Text.Encoding.GetEncoding("gb2312")))
            {
                Console.WriteLine(reader.ReadToEnd());
                //"{\"accessToken\":\"a8f10cd3-3a0c-4d9c-b4ee-2a298630c793\",\"accessTokenTimeout\":36000,\"aliId\":998987466,\"memberId\":\"testfree\",\"resourceOwnerId\":\"testfree66\",\"uid\":\"14346967\"}"
            }*/

            Console.WriteLine("");

            //获取单个会员数据
            /**
            string testApiUrl = "http://gw.open.1688.com/openapi/param2/1/cn.alibaba.open/member.get/" + Config.appKey;

            Dictionary<string, string> apiparameters = new Dictionary<string, string>();
            apiparameters.Add("memberId", "testfree");

            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            TimeSpan t = DateTime.Now - startTime;
            apiparameters.Add("_aop_timestamp", ((long)t.TotalMilliseconds).ToString());//((long)t.TotalMilliseconds - 846).ToString()
            apiparameters.Add("access_token", "736DA4F7B32364D6EBDED1CE663D546BE6DF1A54");
            string new_aop_signature = Sign.sign("param2/1/cn.alibaba.open/member.get/338249", apiparameters, Config.appSecret);
            apiparameters.Add("_aop_signature", new_aop_signature);
            System.Net.HttpWebResponse testresponse = HttpWebResponseUtility.CreatePostHttpResponse(testApiUrl, apiparameters, null, null, encoding, null);
            using (System.IO.StreamReader reader = new System.IO.StreamReader(testresponse.GetResponseStream(), System.Text.Encoding.GetEncoding("utf-8")))
            {
                Console.WriteLine(reader.ReadToEnd());
              
            }
            Console.WriteLine("");
            **/

            string testApiUrl = "http://gw.open.1688.com/openapi/param2/1/cn.alibaba.open/offer.getPublishOfferList/" + Config.appKey;
            Dictionary<string, string> apiparameters = new Dictionary<string, string>();
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            TimeSpan t = DateTime.Now - startTime;
            //apiparameters.Add("_aop_timestamp", ((long)t.TotalMilliseconds).ToString());
            apiparameters.Add("access_token", "98ff5cfe-a452-42d3-993a-d25bdce79d66");
            apiparameters.Add("type", "SALE");
            apiparameters.Add("returnFields", "offerId,subject");
            string new_aop_signature = Sign.sign("param2/1/cn.alibaba.open/offer.getPublishOfferList/338249", apiparameters, Config.appSecret);
            apiparameters.Add("_aop_signature", new_aop_signature);

            
            System.Net.HttpWebResponse testresponse = HttpWebResponseUtility.CreatePostHttpResponse(testApiUrl, apiparameters, null, null, encoding, null);
            using (System.IO.StreamReader reader = new System.IO.StreamReader(testresponse.GetResponseStream(), System.Text.Encoding.GetEncoding("utf-8")))
            {
                Console.WriteLine(reader.ReadToEnd());
                //		reader.ReadToEnd()	"{\"result\":{\"total\":37,\"toReturn\":[{\"subject\":\"无妨布袋\",\"offerId\":35450816236},{\"subject\":\"SKU 数量报价 sku图片\",\"offerId\":35450456682},{\"subject\":\"连衣裙 SKU有选择图片 规格报价\",\"offerId\":35448185898},{\"subject\":\"test\",\"offerId\":35447451547},{\"subject\":\"fafaf\",\"offerId\":35444133022},{\"subject\":\"验证混批起批量\",\"offerId\":1289595331},{\"subject\":\"连衣裙2222\",\"offerId\":35403123727},{\"subject\":\"ABS/奥地利SAX/108 GF20\",\"offerId\":35388019966},{\"subject\":\"rrrrrr\",\"offerId\":35391477019},{\"subject\":\"Test_1012\",\"offerId\":35378949231},{\"subject\":\"ABS/奥地利SAX/106 GF30\",\"offerId\":35388057896},{\"subject\":\"tets发时间欧风是骄傲费家搜批发价\",\"offerId\":35390703331},{\"subject\":\"aaaaaaaaaa\",\"offerId\":35388057964},{\"subject\":\"test法师放哈似乎风骚新发\",\"offerId\":35388298987},{\"subject\":\"232ABB Formula系列塑壳断路器A2N250 TMF160/1\",\"offerId\":1294434683},{\"subject\":\"2123ABB Formula系列塑壳断路器A2N250\",\"offerId\":1294434688},{\"subject\":\"test--lj新发\",\"offerId\":35269296366},{\"subject\":\"新发测试--已修改\",\"offerId\":35278032327},{\"subject\":\"测试安全防护类目的最新成交\",\"offerId\":35255721061},{\"subject\":\"ABS/TESTCCC4/TESTCCC4\",\"offerId\":35089394683},{\"subject\":\"SlimLine隔离开关熔断器组(条形)-XRE00-50-3P;10118779\",\"offerId\":1295183539},{\"subject\":\"fdsafdsaf\",\"offerId\":35074304364},{\"subject\":\"2123ABB Formula系列塑壳断路器A2N250\",\"offerId\":1294434682},{\"subject\":\"SlimLine隔离开关熔断器组(条形)-XRE00-50-3P;10118779\",\"offerId\":1295184411},{\"subject\":\"2123ABB Formula系列塑壳断路器A2N250\",\"offerId\":1294434695},{\"subject\":\"2123ABB Formula系列塑壳断路器A2N250\",\"offerId\":1295193597},{\"subject\":\"SlimLine隔离开关熔断器组(条形)-XRE00-50-3P;10118779\",\"offerId\":1295194887},{\"subject\":\"抗癌灵药-测试商品勿拍\",\"offerId\":1297471708},{\"subject\":\"抗癌灵药-风控测试\",\"offerId\":1297471524},{\"subject\":\"232ABB Formula系列塑壳断路器A2N250 TMF160/1\",\"offerId\":1295193593},{\"subject\":\"SlimLine隔离开关熔断器组(条形)-XRE00-50-3P;10118779\",\"offerId\":1295182963},{\"subject\":\"SlimLine隔离开关熔断器组(条形)-XRE00-50-3P;10118779\",\"offerId\":1295196198},{\"subject\":\"SlimLine隔离开关熔断器组(条形)-XRE00-50-3P;10118779\",\"offerId\":1295186397},{\"subject\":\"2123ABB Formula系列塑壳断路器A2N250\",\"offerId\":1295193590},{\"subject\":\"2123ABB Formula系列塑壳断路器A2N250\",\"offerId\":1295193603}],\"success\":false}}"	string

            }
            Console.WriteLine("");
        }
    }
}
