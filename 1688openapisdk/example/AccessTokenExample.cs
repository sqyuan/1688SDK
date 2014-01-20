using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.request;
using _1688openapisdk.response;
using _1688openapisdk.request.order;
using _1688openapisdk.response.order;
using _1688openapisdk.request.photoalbum;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.request.product;
using _1688openapisdk.response.product;
using _1688openapisdk.request.category;
using _1688openapisdk.response.category;
using _1688openapisdk.request.member;
using _1688openapisdk.response.member;
using _1688openapisdk.request.customer;
using _1688openapisdk.response.customer;
using _1688openapisdk.domain.product;
using _1688openapisdk.domain;
using _1688openapisdk.request.logistics;
using _1688openapisdk.response.logistics;
using _1688openapisdk.request.search;
using _1688openapisdk.response.search;

namespace _1688openapisdk.example
{
    class AccessTokenExample
    {
        //static void mytest()
        static void Main(string[] args)
        {
            ///获取accesstoken示例，注意有效期 ，过期之后如何更新token？
            DefaultAliClient defaultAliClient = new DefaultAliClient("https://gw.open.1688.com/openapi/", "1002071", "WsRIC:O6CF2");
            AccessTokenRequest accessTokenRequest = new AccessTokenRequest();
            accessTokenRequest.account = "testfree66"; //你的1688 memberId
            accessTokenRequest.password = "1111112"; //你的密码
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

            ///获取阿里巴巴阿中国网站会员诚信信息。包括诚信通和诚信保障相关数据
            CreditInfoGetRequest creditInfoGetRequest = new CreditInfoGetRequest();
            creditInfoGetRequest.memberIds = "mmm;cnabblp";
            CreditInfoGetResponse creditInfoGetResponse = defaultAliClient.Execute(creditInfoGetRequest);
            Console.WriteLine(creditInfoGetResponse);

            ///获取阿里巴巴中国网站会员的公司库信息
            CompanyGetRequest companyGetRequest = new CompanyGetRequest();
            companyGetRequest.memberId = "mmm";
            companyGetRequest.access_token = accessTokenResponse.memberId;
            CompanyGetResponse companyGetResponse = defaultAliClient.Execute(companyGetRequest);
            Console.WriteLine(companyGetResponse);

            ///获取阿里巴巴中国网站会员已发布的产品信息列表 offer.getPublishOfferList 示例
            PublishOfferListRequest publishOfferListRequest = new PublishOfferListRequest();
            publishOfferListRequest.access_token = accessTokenResponse.accessToken;
            publishOfferListRequest.type = "SALE";
            publishOfferListRequest.pageSize = 10;
            publishOfferListRequest.page = 2;
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
            //offerQueryRequest.access_token = accessTokenResponse.accessToken;
            offerQueryRequest.offerId = 35687805905;
            offerQueryRequest.returnFields = new string[] { "skuArray", "offerId", "subject", "productFeatureList", "details", "memberId", "postCategryId", "saledCount", "amount", "amountOnSale", "priceRanges", "unit", "gmtModified", "imageList" };
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
            offer.offerId = "1294434695";
            offer.priceRanges = "60:10`70:9`80:313.19";
            offer.subject = "c# sdk test modify title";
            offerModifyIncrementRequest.offer = offer;
            OfferModifyIncrementResponse offerModifyIncrementResponse = defaultAliClient.Execute(offerModifyIncrementRequest);
            Console.WriteLine(offerModifyIncrementResponse);

            ///offer.modify.increment 增量修改offer SKU价格（该接口只支持价格和标题的增量修改！请慎用！）
            OfferModifyIncrementRequest offerModifyIncrementRequest1 = new OfferModifyIncrementRequest();
            offerModifyIncrementRequest1.access_token = accessTokenResponse.accessToken;
            OfferModifyIncrement offer1 = new OfferModifyIncrement();
            offer1.offerId = "35687805905";
            OfferSkuParam[] offerSkuParam = new OfferSkuParam[1];
            OfferSkuParam OfferSkuParam1 = new OfferSkuParam();
            OfferSkuParam1.specAttributes = new Dictionary<string, string>();
            OfferSkuParam1.specAttributes.Add("450", "XXS");
            OfferSkuParam1.specAttributes.Add("3216", "黑色");
            OfferSkuParam1.amountOnSale = 100;
            OfferSkuParam1.price = 2000;
            OfferSkuParam1.retailPrice = 3000;
            OfferSkuParam1.cargoNumber = "11";
            offerSkuParam[0] = OfferSkuParam1;
            offer1.skuList = offerSkuParam;
            offerModifyIncrementRequest1.offer = offer1;
   ///         OfferModifyIncrementResponse offerModifyIncrementResponse1 = defaultAliClient.Execute(offerModifyIncrementRequest1);
   ///         Console.WriteLine(offerModifyIncrementResponse1);

            //用户运费模板列表描述查询
            E56DeliveryTemplateListRequest e56DeliveryTemplateListRequest = new E56DeliveryTemplateListRequest();
            e56DeliveryTemplateListRequest.memberId = "testfree";
            e56DeliveryTemplateListRequest.access_token = accessTokenResponse.accessToken;
            E56DeliveryTemplateListResponse e56DeliveryTemplateListResponse = defaultAliClient.Execute(e56DeliveryTemplateListRequest);
            Console.WriteLine(e56DeliveryTemplateListResponse);
            E56DeliveryTemplateGetRequest e56DeliveryTemplateGetRequest = new E56DeliveryTemplateGetRequest();
            e56DeliveryTemplateGetRequest.memberId = "testfree";
            e56DeliveryTemplateGetRequest.access_token = accessTokenResponse.accessToken;
            e56DeliveryTemplateGetRequest.templateId = "1069818";
            E56DeliveryTemplateGetResponse e56DeliveryTemplateGetResponse = defaultAliClient.Execute(e56DeliveryTemplateGetRequest);
            Console.WriteLine(e56DeliveryTemplateGetResponse);

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

            ///本接口实现获取当前用户相册列表
            IbankAlbumListRequest ibankAlbumListRequest = new IbankAlbumListRequest();
            ibankAlbumListRequest.access_token = accessTokenResponse.accessToken;
            ibankAlbumListRequest.albumType = "MY";
            ibankAlbumListRequest.pageNo = 1;
            ibankAlbumListRequest.pageSize = 20;
            IbankAlbumListResponse ibankAlbumListResponse = defaultAliClient.Execute(ibankAlbumListRequest);
            Console.WriteLine(ibankAlbumListResponse.toReturn);

            ///本接口实现获取当前用户相册内图片列表
            IbankImageListRequest ibankImageListRequest = new IbankImageListRequest();
            ibankImageListRequest.access_token = accessTokenResponse.accessToken;
            ibankImageListRequest.albumId = 10971051;
            ibankImageListRequest.pageNo = 1;
            ibankImageListRequest.pageSize = 50;
            IbankImageListResponse ibankImageListResponse = defaultAliClient.Execute(ibankImageListRequest);
            Console.WriteLine(ibankImageListResponse.toReturn);

            ///根据叶子类目ID获取类目发布属性信息 offerPostFeatures.get -- version: 1
            OfferPostFeaturesGetRequest offerPostFeaturesGetRequest = new OfferPostFeaturesGetRequest();
            offerPostFeaturesGetRequest.categoryID = 1031910;
            OfferPostFeaturesGetResponse OfferPostFeaturesGetResponse = defaultAliClient.Execute(offerPostFeaturesGetRequest);
            Console.WriteLine(OfferPostFeaturesGetResponse);

            //根据类目ID获取商品发布类目信息 category.getPostCatList -- version: 1
            CategoryGetPostCatListRequest categoryGetPostCatListRequest = new CategoryGetPostCatListRequest();
            categoryGetPostCatListRequest.catIDs = "1031910,10166";
            CategoryGetPostCatListResponse categoryGetPostCatListResponse = defaultAliClient.Execute(categoryGetPostCatListRequest);
            Console.WriteLine(categoryGetPostCatListResponse);

            ///本接口实现阿里巴巴中文站登录会员，根据交易信息获取当前卖家的会员信息
            AcrmCustomerTradeGetRequest acrmCustomerTradeGetRequest = new AcrmCustomerTradeGetRequest();
            acrmCustomerTradeGetRequest.memberId = "testfree";
            acrmCustomerTradeGetRequest.access_token = accessTokenResponse.accessToken;
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

            ///新接口查询当前会话会员的交易订单列表
            OrderListInfoRequest orderListInfoRequest = new OrderListInfoRequest();
            orderListInfoRequest.access_token = accessTokenResponse.accessToken;
            orderListInfoRequest.sellerMemberId = "testfree";
            orderListInfoRequest.pageSize = 20;
            orderListInfoRequest.page = 1;
            OrderListInfoResponse OrderListInfoResponse = defaultAliClient.Execute(orderListInfoRequest);
            Console.WriteLine(OrderListInfoResponse);

            ///新本接口查询当前会话会员的交易订单详情
            NewTradeOrderDetailGetRequest newTradeOrderDetailGetRequest = new NewTradeOrderDetailGetRequest();
            newTradeOrderDetailGetRequest.access_token = accessTokenResponse.accessToken;
            newTradeOrderDetailGetRequest.id = 440136255012834;
            NewTradeOrderDetailGetResponse newtradeOrderDetailGetResponse = defaultAliClient.Execute(newTradeOrderDetailGetRequest);
            Console.WriteLine(newtradeOrderDetailGetResponse);

            ///用户在发布offer时候，需要选择对应的发布类目，类目作弊就是用来检测选择的类目跟发布的offer信息是否匹配
            SearchCategoryCheatingRequest searchCategoryCheatingRequest = new SearchCategoryCheatingRequest();
            searchCategoryCheatingRequest.userid = "testfree";
            searchCategoryCheatingRequest.title = "喷泉水景是单价的offer22";
            searchCategoryCheatingRequest.catid = "30";
            SearchCategoryCheatingResponse searchCategoryCheatingResponse = defaultAliClient.Execute(searchCategoryCheatingRequest);
            Console.WriteLine(searchCategoryCheatingResponse.body);

            ///用来判断，用户标题和属性中填写的信息是否一致，是否存在冲突的关键属性
            SearchTitlePropertiesInconsistentRequest searchTitlePropertiesInconsistentRequest = new SearchTitlePropertiesInconsistentRequest();
            searchTitlePropertiesInconsistentRequest.catid = "1046737";
            searchTitlePropertiesInconsistentRequest.title = "喷泉水景是单价的offer22";
            searchTitlePropertiesInconsistentRequest.brief = "产品类别:洗衣液 品牌:Tide/汰渍";
            SearchTitlePropertiesInconsistentResponse searchTitlePropertiesInconsistentResponse = defaultAliClient.Execute(searchTitlePropertiesInconsistentRequest);
            Console.WriteLine(searchTitlePropertiesInconsistentResponse.body);

            ///判断用户填写的属性是否存在滥用，比如属性值多个重复使用，属性值过长，以及属性值无意义等。
            SearchPropertiesAbuseRequest searchPropertiesAbuseRequest = new SearchPropertiesAbuseRequest();
            searchPropertiesAbuseRequest.catid = "1046737";
            searchPropertiesAbuseRequest.brief = "产品类别:洗衣液 品牌:Tide/汰渍 货号:TZ-200 类型:浓缩型 适用范围:所有衣物 香型:自然 净含量:200-350g/ml 产地:中国 箱装数量:30";
            SearchPropertiesAbuseResponse searchPropertiesAbuseResponse = defaultAliClient.Execute(searchPropertiesAbuseRequest);
            Console.WriteLine(searchPropertiesAbuseResponse.body);

            SearchTitleStuffingReqeust searchTitleStuffingReqeust = new SearchTitleStuffingReqeust();
            searchTitleStuffingReqeust.query = "ABB 品牌 品牌ABB口罩 防护口罩";
            SearchTitleStuffingResponse SearchTitleStuffingResponse = defaultAliClient.Execute(searchTitleStuffingReqeust);
            Console.WriteLine(SearchTitleStuffingResponse.body);
        }
    }
}
