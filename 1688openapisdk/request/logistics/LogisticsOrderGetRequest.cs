using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;

namespace _1688openapisdk.domain
{
    /// <summary>
    /// 获取物流单列表
    /// </summary>
    public class LogisticsOrderGetRequest : IAliRequest<LogisticsOrderGetResponse>
    {
        /// <summary>
        /// 用户中文站memberId
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// 交易订单来源,支持的来源有：cbu-trade
        /// </summary>
        public string tradeSourceType { get; set; }

        /// <summary>
        /// 需要返回的字段，目前有:company.name,sender,receiver,sendgood。返回的字段要用英文逗号分隔开
        /// </summary>
        public string fields { get; set; }

        public string access_token { get; set; }

        string IAliRequest<LogisticsOrderGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/e56.logistics.orders.get/";
        }

        IDictionary<string, string> IAliRequest<LogisticsOrderGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            parameters.Add("orderId", this.orderId);
            parameters.Add("tradeSourceType", this.tradeSourceType);
            if (this.fields != null)
            {
                parameters.Add("fields", this.fields);
            } 
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<LogisticsOrderGetResponse>.Validate()
        {
            if (this.memberId == null || this.orderId == null || this.tradeSourceType == null || this.access_token == null)
            {
                throw new AliException("memberId,orderId,tradeSourceType,access_token must not be null");
            }
        }

        object IAliRequest<LogisticsOrderGetResponse>.GetReturnType()
        {
            return typeof(LogisticsOrderGetResponse);
        }
    }
}
