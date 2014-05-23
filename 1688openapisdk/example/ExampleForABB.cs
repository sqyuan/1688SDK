using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain;
using _1688openapisdk.response;
using _1688openapisdk.domain.member;
using _1688openapisdk.domain.product;
using _1688openapisdk.response.product;
using _1688openapisdk.domain.product;
using _1688openapisdk.domain.customer;
using _1688openapisdk.response.customer;
using _1688openapisdk.domain;

namespace _1688openapisdk.example
{
    //ABB使用接口示例
    public class ExampleForABB
    {
        static void testMain(string[] args)
        //static void Main(string[] args)
        {
            ///获取accesstoken示例，注意有效期
            DefaultAliClient defaultAliClient = new DefaultAliClient("https://gw.open.1688.com/openapi/", "1002071", "WsRIC:O6CF2");
            AccessTokenRequest accessTokenRequest = new AccessTokenRequest();
            accessTokenRequest.account = "testfree66"; //你的1688 memberId
            accessTokenRequest.password = "1111112"; //你的密码
            AccessTokenResponse accessTokenResponse = defaultAliClient.Execute(accessTokenRequest);
            Jayrock.Json.JsonTextWriter writer = new Jayrock.Json.JsonTextWriter();
            Jayrock.Json.Conversion.JsonConvert.Export(accessTokenResponse, writer);
            string str = writer.ToString();
            Console.WriteLine(str);

            ///获取阿里巴巴中国网站会员已发布的产品信息列表 offer.getPublishOfferList 示例
            PublishOfferListRequest publishOfferListRequest = new PublishOfferListRequest();
            publishOfferListRequest.access_token = accessTokenResponse.accessToken;
            publishOfferListRequest.type = "SALE";
            publishOfferListRequest.pageSize = 10;
            publishOfferListRequest.page = 2;
            publishOfferListRequest.returnFields = new string[] { "offerId", "subject", "productFeatureList", "details", "memberId", "postCategryId", "saledCount", "amountOnSale", "priceRanges", "unit", "gmtModified", "imageList" };
            PublishOfferListResponse publishOfferListResponse = defaultAliClient.Execute(publishOfferListRequest);
            Console.WriteLine(publishOfferListResponse.toReturn);
            //获取阿里的产品id跟物料编号的对应关系
            foreach(OfferDetailInfo offerDetailInfo in publishOfferListResponse.toReturn)
            {
                foreach (ProductFeatureInfo productFeatureInfo in offerDetailInfo.productFeatureList)
                {
                    if (productFeatureInfo.name.Equals("物料编号"))
                    {
                        Console.WriteLine("产品Id:" + offerDetailInfo.offerId + "  物料编号：" + productFeatureInfo.value);
                    }
                }
            }
            Jayrock.Json.JsonTextWriter writer2 = new Jayrock.Json.JsonTextWriter();
            Jayrock.Json.Conversion.JsonConvert.Export(publishOfferListResponse, writer2);
            string str2 = writer2.ToString();
            Console.WriteLine(str2);

            ///获取阿里巴巴中国网站会员所有的产品信息列表 offer.getAllOfferList -- version: 1 示例
            AllOfferListRequest allOfferListRequest = new AllOfferListRequest();
            allOfferListRequest.access_token = accessTokenResponse.accessToken;
            allOfferListRequest.type = "SALE";
            allOfferListRequest.returnFields = new string[] { "offerId", "subject", "productFeatureList", "details", "memberId", "postCategryId", "saledCount", "amountOnSale", "priceRanges", "unit", "gmtModified", "imageList" };
            PublishOfferListResponse publishOfferListResponse1 = defaultAliClient.Execute(allOfferListRequest);
            Console.WriteLine(publishOfferListResponse1.toReturn);


            ///查询单个产品信息 offer.get -- version: 1
            OfferQueryRequest offerQueryRequest = new OfferQueryRequest();
           // offerQueryRequest.access_token = accessTokenResponse.accessToken;
            offerQueryRequest.offerId = 36379282867;
            offerQueryRequest.returnFields = new string[] { "skuList", "offerId", "subject", "productFeatureList", "details", "memberId", "postCategryId", "saledCount", "amount", "amountOnSale", "priceRanges", "unit", "gmtModified", "imageList" };
            OfferResponse offerResponse = defaultAliClient.Execute(offerQueryRequest);
            Console.WriteLine(offerResponse.toReturn.ToString());

            ///增量修改产品库存 offer.modify.stock -- version: 1
            OfferModifyStockRequest offerModifyStockRequest = new OfferModifyStockRequest();
            offerModifyStockRequest.offerId = 36379282867;//产品id
            offerModifyStockRequest.offerAmountChange = 1; //+表示增加，负表示减少
            offerModifyStockRequest.access_token = accessTokenResponse.accessToken;
            Dictionary<string, string> skuAmountChange = new Dictionary<string, string>();
            skuAmountChange.Add("8a83875664478078358187ed938f4bab", "1");//如果是sku 产品，则需要修改sku的库存
            offerModifyStockRequest.skuAmountChange = skuAmountChange;
            OfferModifyStockResponse offerModifyStockResponse = defaultAliClient.Execute(offerModifyStockRequest);
            Console.WriteLine(offerModifyStockResponse);

            ///offer.modify.increment 增量修改offer（该接口只支持价格和标题的增量修改！请慎用！）
            OfferModifyIncrementRequest offerModifyIncrementRequest = new OfferModifyIncrementRequest();
            offerModifyIncrementRequest.access_token = accessTokenResponse.accessToken;
            OfferModifyIncrement offer = new OfferModifyIncrement();
            offer.offerId = "1295193597";
            offer.priceRanges = "60:10`70:9`80:8"; //修改价格区间
            offer.subject = "c# sdk test modify title";//修改标题
            offerModifyIncrementRequest.offer = offer;
            OfferModifyIncrementResponse offerModifyIncrementResponse = defaultAliClient.Execute(offerModifyIncrementRequest);
            Console.WriteLine(offerModifyIncrementResponse);

            ///获取提供该服务的物流公司列表 e56.logistics.companies.get -- version: 1
            LogisticsCompaniesGetRequest logisticsCompaniesGetRequest = new LogisticsCompaniesGetRequest();
            logisticsCompaniesGetRequest.access_token = accessTokenResponse.accessToken;
            logisticsCompaniesGetRequest.memberId = "testfree";
            logisticsCompaniesGetRequest.serviceType = "ZX";
            LogisticsCompaniesGetResponse logisticsCompaniesGetResponse = defaultAliClient.Execute(logisticsCompaniesGetRequest);
            Console.WriteLine(logisticsCompaniesGetResponse);

            ///用户调用该接口可实现自己联系发货（线下物流），使用该接口发货，交易订单状态会直接变成卖家已发货。不支持货到付款、在线下单类型的订单。e56.logistics.offline.send -- version: 1
            LogisticsOfflineSendRequest logisticsOfflineSendRequest = new LogisticsOfflineSendRequest();
            logisticsOfflineSendRequest.memberId = "testfree";
            logisticsOfflineSendRequest.orderId = "404252368801798";
            logisticsOfflineSendRequest.orderEntryIds = "404252368801798";
            logisticsOfflineSendRequest.tradeSourceType = "cbu-trade";
            logisticsOfflineSendRequest.logisticsCompanyId = "3"; //物流公司id
            logisticsOfflineSendRequest.selfCompanyName = "中通速递";//物流公司名称
            logisticsOfflineSendRequest.logisticsBillNo = "768070181853";//运单号
            logisticsOfflineSendRequest.gmtSystemSend = "2013-10-23 11:21:35";
            logisticsOfflineSendRequest.gmtLogisticsCompanySend = "2013-10-23 11:21:35";
            logisticsOfflineSendRequest.access_token = accessTokenResponse.accessToken;
            //LogisticsOfflineSendResponse logisticsOfflineSendResponse = defaultAliClient.Execute(logisticsOfflineSendRequest);
            //Console.WriteLine(logisticsOfflineSendResponse);

            ///本接口实现阿里巴巴中文站登录会员，根据交易信息获取当前卖家的会员信息
            AcrmCustomerTradeGetRequest acrmCustomerTradeGetRequest = new AcrmCustomerTradeGetRequest();
            acrmCustomerTradeGetRequest.memberId = "testfree";
            acrmCustomerTradeGetRequest.access_token = accessTokenResponse.accessToken;
            acrmCustomerTradeGetRequest.pageSize = 100;
            acrmCustomerTradeGetRequest.pageNum = 2;
            AcrmCustomerTradeGetResponse acrmCustomerTradeGetResponse = defaultAliClient.Execute(acrmCustomerTradeGetRequest);
            Console.WriteLine(acrmCustomerTradeGetResponse);

            ///查询某个memberId下面所有的分组标签
            AcrmGroupsGetRequest acrmGroupsGetRequest = new AcrmGroupsGetRequest();
            acrmGroupsGetRequest.memberId = "testfree";
            acrmGroupsGetRequest.access_token = accessTokenResponse.accessToken;
            AcrmGroupsGetResponse AcrmGroupsGetResponse = defaultAliClient.Execute(acrmGroupsGetRequest);
            Console.WriteLine(AcrmGroupsGetResponse);

            ///本接口实现阿里巴巴中文站登录会员，根据标签获取当前卖家的会员信息
            AcrmCustomerGroupGetRequest acrmCustomerGroupGetRequest = new AcrmCustomerGroupGetRequest();
            acrmCustomerGroupGetRequest.memberId = "testfree";
            acrmCustomerGroupGetRequest.access_token = accessTokenResponse.accessToken;
            acrmCustomerGroupGetRequest.groupId = 8416600;
            acrmCustomerGroupGetRequest.pageNum = 1;
            acrmCustomerGroupGetRequest.pageSize = 20;
            AcrmCustomerGroupGetResponse acrmCustomerGroupGetResponse = defaultAliClient.Execute(acrmCustomerGroupGetRequest);
            Console.WriteLine(acrmCustomerGroupGetResponse);

            ///本接口实现阿里巴巴中文站登录会员，根据等级获取当前卖家的会员信息
            AcrmCustomerRelationGetRequest AcrmCustomerRelationGetRequest = new AcrmCustomerRelationGetRequest();
            AcrmCustomerRelationGetRequest.memberId = "testfree";
            AcrmCustomerRelationGetRequest.access_token = accessTokenResponse.accessToken;
            AcrmCustomerRelationGetRequest.level = 1;
            AcrmCustomerRelationGetRequest.pageNum = 1;
            AcrmCustomerRelationGetRequest.pageSize = 20;
            AcrmCustomerRelationGetResponse AcrmCustomerRelationGetResponse = defaultAliClient.Execute(AcrmCustomerRelationGetRequest);
            Console.WriteLine(AcrmCustomerRelationGetResponse);
        }
    }
}
