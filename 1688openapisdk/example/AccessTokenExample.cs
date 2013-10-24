using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.request;
using _1688openapisdk.response;

namespace _1688openapisdk.example
{
    class AccessTokenExample
    {
        static void Main(string[] args)
        {
            ///获取accesstoken示例，注意有效期
            DefaultAliClient defaultAliClient = new DefaultAliClient("https://gw.open.1688.com/openapi/", "338249", "JpmpVnOvJb");
            AccessTokenRequest accessTokenRequest = new AccessTokenRequest();
            accessTokenRequest.account = "testfree66";
            accessTokenRequest.password = "1111112";
            AccessTokenResponse accessTokenResponse = defaultAliClient.Execute(accessTokenRequest);
            Jayrock.Json.JsonTextWriter writer = new Jayrock.Json.JsonTextWriter();
            Jayrock.Json.Conversion.JsonConvert.Export(accessTokenResponse, writer);
            string str = writer.ToString();
            Console.WriteLine(str);

            ///
            /// 查询会员信息示例
            ///
            MemberInfoRequest memberInfoRequest = new MemberInfoRequest();
            memberInfoRequest.access_token = accessTokenResponse.accessToken;
            memberInfoRequest.memberId = accessTokenResponse.memberId;
            MemberInfoResponse memberInfoResponse = defaultAliClient.Execute(memberInfoRequest);
            Console.WriteLine(memberInfoResponse.toReturn.isTP);
            Jayrock.Json.JsonTextWriter writer1 = new Jayrock.Json.JsonTextWriter();
            Jayrock.Json.Conversion.JsonConvert.Export(memberInfoResponse, writer1);
            string str1 = writer1.ToString();
            Console.WriteLine(str1);

            ///获取阿里巴巴中国网站会员已发布的产品信息列表 offer.getPublishOfferList 示例
            PublishOfferListRequest publishOfferListRequest = new PublishOfferListRequest();
            publishOfferListRequest.access_token = accessTokenResponse.accessToken;
            publishOfferListRequest.type = "SALE";
            publishOfferListRequest.returnFields = new string[] { "offerId", "subject", "productFeatureList", "details", "memberId", "postCategryId", "saledCount", "amountOnSale", "priceRanges", "unit", "gmtModified" };
            PublishOfferListResponse publishOfferListResponse = defaultAliClient.Execute(publishOfferListRequest);
            Console.WriteLine(publishOfferListResponse.toReturn);
            Jayrock.Json.JsonTextWriter writer2 = new Jayrock.Json.JsonTextWriter();
            Jayrock.Json.Conversion.JsonConvert.Export(publishOfferListResponse, writer2);
            string str2 = writer2.ToString();
            Console.WriteLine(str2);

        }
    }
}
