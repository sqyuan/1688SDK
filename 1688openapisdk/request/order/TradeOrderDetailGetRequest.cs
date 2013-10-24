using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.order;

namespace _1688openapisdk.request.order
{
    public class TradeOrderDetailGetRequest : IAliRequest<TradeOrderDetailGetResponse>
    {
        public string access_token { get; set; }

        /// <summary>
        /// 订单ID号
        /// </summary>
        public long orderId { get; set; }

        string IAliRequest<TradeOrderDetailGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/trade.order.orderDetail.get/";
        }

        IDictionary<string, string> IAliRequest<TradeOrderDetailGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("orderId", this.orderId.ToString());
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<TradeOrderDetailGetResponse>.Validate()
        {
            if (this.orderId == 0)
            {
                throw new AliException("orderId must not be null");
            }
        }

        object IAliRequest<TradeOrderDetailGetResponse>.GetReturnType()
        {
            return typeof(TradeOrderDetailGetResponse);
        }
    }
}
