using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;

namespace _1688openapisdk.request
{
    public class LogisticsTraceGetRequest : IAliRequest<LogisticsTraceGetResponse>
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

        public string access_token { get; set; }

        string IAliRequest<LogisticsTraceGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/e56.logistics.trace.get/";
        }

        IDictionary<string, string> IAliRequest<LogisticsTraceGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            parameters.Add("orderId", this.orderId);
            parameters.Add("tradeSourceType", this.tradeSourceType);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<LogisticsTraceGetResponse>.Validate()
        {
            if (this.memberId == null || this.orderId == null || this.tradeSourceType == null || this.access_token == null)
            {
                throw new AliException("memberId,orderId,tradeSourceType,access_token must not be null");
            }
        }

        object IAliRequest<LogisticsTraceGetResponse>.GetReturnType()
        {
            return typeof(LogisticsTraceGetResponse);
        }
    }
}
