using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.order;
using _1688openapisdk.domain.order;

namespace _1688openapisdk.request.order
{
    /// <summary>
    /// 批量提交订单评价 此接口支持多笔订单（暂定最多10笔每次）同时提交评价，并且只支持卖家向买家的评价，目前当某笔订单存在多个商品时,只能为这笔订单的这些商品提交相同的评价内容。
    /// </summary>
    public class TradeOrderBatchRateRequest : IAliRequest<TradeOrderBatchRateResponse>
    {
        /// <summary>
        /// 订单评价：Map(String,TradeRateParam[]),前者为订单号，后者为评价内容与星级,结构请看数据结构订单评价参数。 评价星级(starLevel)必须是1-5, 当starLevel < 4 时必须同时指定评价内容
        ///{ // 批量提交评价的订单 "92154312490525" : [ // 主订单1 { "starLevel" : "1", // 星级 "content" : "差评的" // 评价内容 } ], "92154312590525" : [ // 主订单2 { "starLevel" : "5", // 星级 "content" : "好评的" // 评价内容 } ] }
        /// </summary>
        public IDictionary<String, TradeRateParam[]> orders { get; set; }

        public string access_token { get; set; }

        string IAliRequest<TradeOrderBatchRateResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/trade.order.batch.rate/";
        }

        IDictionary<string, string> IAliRequest<TradeOrderBatchRateResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            Jayrock.Json.JsonTextWriter writer = new Jayrock.Json.JsonTextWriter();
            Jayrock.Json.Conversion.JsonConvert.Export(orders, writer);
            string str = writer.ToString();
            parameters.Add("orders", str);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<TradeOrderBatchRateResponse>.Validate()
        {
            if (this.orders == null)
            {
                throw new AliException("orders must not be null");
            }
        }

        object IAliRequest<TradeOrderBatchRateResponse>.GetReturnType()
        {
            return typeof(Dictionary<String, String>);
        }
    }
}
