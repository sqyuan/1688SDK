using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.request;
using _1688openapisdk.response;
using _1688openapisdk.request.order;
using _1688openapisdk.response.order;
using _1688openapisdk.request.photoalbum;
using _1688openapisdk.response.photoalbum;

namespace _1688openapisdk.example
{
    class AccessTokenExample
    {
        static void Main(string[] args)
        {
            ///获取accesstoken示例，注意有效期
            DefaultAliClient defaultAliClient = new DefaultAliClient("https://gw.open.1688.com/openapi/", "1002071", "WsRIC:O6CF2");
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
            publishOfferListRequest.returnFields = new string[] { "offerId", "subject", "productFeatureList", "details", "memberId", "postCategryId", "saledCount", "amountOnSale", "priceRanges", "unit", "gmtModified", "imageList" };
            PublishOfferListResponse publishOfferListResponse = defaultAliClient.Execute(publishOfferListRequest);
            Console.WriteLine(publishOfferListResponse.toReturn);
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
            offerQueryRequest.access_token = accessTokenResponse.accessToken;
            offerQueryRequest.offerId = 1224610587;
            offerQueryRequest.returnFields = new string[] { "offerId", "subject", "productFeatureList", "details", "memberId", "postCategryId", "saledCount", "amountOnSale", "priceRanges", "unit", "gmtModified", "imageList" };
            OfferResponse offerResponse = defaultAliClient.Execute(offerQueryRequest);
            Console.WriteLine(offerResponse.toReturn.ToString());

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
            logisticsOfflineSendRequest.logisticsCompanyId = "3";
            logisticsOfflineSendRequest.selfCompanyName = "中通速递";
            logisticsOfflineSendRequest.logisticsBillNo = "768070181853";
            logisticsOfflineSendRequest.gmtSystemSend = "2013-10-23 11:21:35";
            logisticsOfflineSendRequest.gmtLogisticsCompanySend = "2013-10-23 11:21:35";
            logisticsOfflineSendRequest.access_token = accessTokenResponse.accessToken;
            //LogisticsOfflineSendResponse logisticsOfflineSendResponse = defaultAliClient.Execute(logisticsOfflineSendRequest);
            //Console.WriteLine(logisticsOfflineSendResponse);


            ///用户根据交易号查询物流流转信息，如2010-8-10 15：23：00到达杭州集散地。 此接口的返回信息都由物流公司提供。e56.logistics.trace.get -- version: 1
            LogisticsOrderGetRequest logisticsOrderGetRequest = new LogisticsOrderGetRequest();
            logisticsOrderGetRequest.memberId = "testfree";
            logisticsOrderGetRequest.orderId = "404252368801798";
            logisticsOrderGetRequest.tradeSourceType = "cbu-trade";
            logisticsOrderGetRequest.fields = "company.name,sender,receiver,sendgood";
            logisticsOrderGetRequest.access_token = accessTokenResponse.accessToken;
            LogisticsOrderGetResponse logisticsOrderGetResponse = defaultAliClient.Execute(logisticsOrderGetRequest);
            Console.WriteLine(logisticsOrderGetResponse);

            ///根据交易订单ID, 获取该订单下的物流单列表 e56.logistics.orders.get -- version: 1
            LogisticsTraceGetRequest logisticsTraceGetRequest = new LogisticsTraceGetRequest();
            logisticsTraceGetRequest.memberId = "testfree";
            logisticsTraceGetRequest.orderId = "404252368801798";
            logisticsTraceGetRequest.tradeSourceType = "cbu-trade";
            logisticsTraceGetRequest.access_token = accessTokenResponse.accessToken;
            LogisticsTraceGetResponse logisticsTraceGetResponse = defaultAliClient.Execute(logisticsTraceGetRequest);
            Console.WriteLine(logisticsTraceGetResponse);


            ///本接口查询当前会话会员的交易订单列表
            TradeOrderListGetRequest tradeOrderListGetRequest = new TradeOrderListGetRequest();
            tradeOrderListGetRequest.access_token = accessTokenResponse.accessToken;
            tradeOrderListGetRequest.sellerMemberId = "testfree";
            tradeOrderListGetRequest.pageSize = 20;
            tradeOrderListGetRequest.pageNO = 1;
            TradeOrderListGetResponse tradeOrderListGetResponse = defaultAliClient.Execute(tradeOrderListGetRequest);
            Console.WriteLine(tradeOrderListGetResponse);


            ///本接口查询当前会话会员的交易订单详情
            TradeOrderDetailGetRequest tradeOrderDetailGetRequest = new TradeOrderDetailGetRequest();
            tradeOrderDetailGetRequest.access_token = accessTokenResponse.accessToken;
            tradeOrderDetailGetRequest.orderId = 404252368801798;
            TradeOrderDetailGetResponse tradeOrderDetailGetResponse = defaultAliClient.Execute(tradeOrderDetailGetRequest);
            Console.WriteLine(tradeOrderDetailGetResponse);

            ///本接口实现获取指定会员在阿里巴巴中文站上的发货地址列表信息
            TradeFreightSendGoodsAddressListGetRequest tradeFreightSendGoodsAddressListGetRequest = new TradeFreightSendGoodsAddressListGetRequest();
            tradeFreightSendGoodsAddressListGetRequest.access_token = accessTokenResponse.accessToken;
            tradeFreightSendGoodsAddressListGetRequest.memberId = "testfree";
            tradeFreightSendGoodsAddressListGetRequest.returnFields = "deliveryAddressId,updateTime,isCommonUse,contactName,location,address,postcode,telephone,mobilephone";
            TradeFreightSendGoodsAddressListGetResponse tradeFreightSendGoodsAddressListGetResponse = defaultAliClient.Execute(tradeFreightSendGoodsAddressListGetRequest);
            Console.WriteLine(tradeFreightSendGoodsAddressListGetResponse);


            ///本接口实现获取指定会员在阿里巴巴中文站上的物流模板列表信息
            TradeFreightTemplateListGetRequest tradeFreightTemplateListGetRequest = new TradeFreightTemplateListGetRequest();
            tradeFreightTemplateListGetRequest.access_token = accessTokenResponse.accessToken;
            tradeFreightTemplateListGetRequest.memberId = "testfree";
            TradeFreightTemplateListGetResponse tradeFreightTemplateListGetResponse = defaultAliClient.Execute(tradeFreightTemplateListGetRequest);
            Console.WriteLine(tradeFreightTemplateListGetResponse);

            ///获取省份编码信息
            AreaCodeGetRequest areaCodeGetRequest = new AreaCodeGetRequest();
            AreaCodeGetResponse areaCodeGetResponse = defaultAliClient.Execute(areaCodeGetRequest);
            Console.WriteLine(areaCodeGetResponse.toReturn);
            Console.WriteLine(accessTokenResponse);

            ///本接口实现获取当前用户信息，包括可用空间和总空间等
            IbankProfileGetRequest ibankProfileGetRequest = new IbankProfileGetRequest();
            ibankProfileGetRequest.access_token = accessTokenResponse.accessToken;
            IbankProfileGetResponse IbankProfileGetResponse = defaultAliClient.Execute(ibankProfileGetRequest);
            Console.WriteLine(IbankProfileGetResponse);
        }
    }
}
