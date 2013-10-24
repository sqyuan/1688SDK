using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;

namespace _1688openapisdk.request
{
    public class LogisticsDummySendRequest : IAliRequest<LogisticsDummySendResponse>
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
        /// 订单明细ID, 多个明细请用英文逗号分隔
        /// </summary>
        public string orderEntryIds { get; set; }

        /// <summary>
        /// 交易订单来源,支持的来源有：cbu-trade
        /// </summary>
        public string tradeSourceType { get; set; }

        /// <summary>
        /// 用户备注
        /// </summary>
        public string remarks { get; set; }

        /// <summary>
        /// 物流公司ID
        /// </summary>
        public string logisticsCompanyId { get; set; }

        /// <summary>
        /// 系统发货时间
        /// </summary>
        public string gmtSystemSend { get; set; }

        /// <summary>
        /// 卖家发货时间
        /// </summary>
        public string gmtLogisticsCompanySend { get; set; }

        public string access_token { get; set; }

        string IAliRequest<LogisticsDummySendResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/e56.logistics.dummy.send/";
        }

        IDictionary<string, string> IAliRequest<LogisticsDummySendResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            parameters.Add("orderId", this.orderId);
            parameters.Add("orderEntryIds", this.orderEntryIds);
            parameters.Add("tradeSourceType", this.tradeSourceType);
            parameters.Add("remarks", this.remarks);
            parameters.Add("logisticsCompanyId", this.logisticsCompanyId);
            parameters.Add("gmtSystemSend", this.gmtSystemSend);
            parameters.Add("gmtLogisticsCompanySend", this.gmtLogisticsCompanySend);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<LogisticsDummySendResponse>.Validate()
        {
            if (this.memberId == null || this.orderId == null || this.orderEntryIds == null || this.tradeSourceType == null || this.logisticsCompanyId == null
                || this.gmtSystemSend == null || this.gmtLogisticsCompanySend == null || this.access_token == null)
            {
                throw new AliException("argument must not be null");
            }
        }

        object IAliRequest<LogisticsDummySendResponse>.GetReturnType()
        {
            throw new NotImplementedException();
        }
    }
}

