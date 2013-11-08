using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.order;

namespace _1688openapisdk.request.order
{
     /// <summary>
    /// 查询单个订单详情，新版的查询详情接口，不含隐私数据
    /// </summary>
    public class NewTradeOrderDetailGetRequest : IAliRequest<NewTradeOrderDetailGetResponse>
    {
        public string access_token { get; set; }

        /// <summary>
        /// 订单ID号
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 是否需要订单明细	默认true
        /// </summary>
        public Boolean needOrderEntries { get; set; }

        /// <summary>
        /// 是否需要发票信息 默认true
        /// </summary>
        public Boolean needInvoiceInfo { get; set; }

        /// <summary>
        /// 是否需要订单备注 默认true
        /// </summary>
        public Boolean needOrderMemoList { get; set; }

        /// <summary>
        /// 是否需要物流单信息 默认true
        /// </summary>
        public Boolean needLogisticsOrderList { get; set; }

        string IAliRequest<NewTradeOrderDetailGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/trade.order.detail.get/";
        }

        IDictionary<string, string> IAliRequest<NewTradeOrderDetailGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("id", this.id.ToString());
            if (this.needOrderEntries != null)
            {
                parameters.Add("needOrderEntries", this.needOrderEntries.ToString());
            }
            if (this.needInvoiceInfo != null)
            {
                parameters.Add("needInvoiceInfo", this.needInvoiceInfo.ToString());
            }
            if (this.needOrderMemoList != null)
            {
                parameters.Add("needOrderMemoList", this.needOrderMemoList.ToString());
            }
            if (this.needLogisticsOrderList != null)
            {
                parameters.Add("needLogisticsOrderList", this.needLogisticsOrderList.ToString());
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<NewTradeOrderDetailGetResponse>.Validate()
        {
            if (this.id == 0)
            {
                throw new AliException("orderId must not be null");
            }
        }

        object IAliRequest<NewTradeOrderDetailGetResponse>.GetReturnType()
        {
            return typeof(TradeOrderDetailGetResponse);
        }
    }
}
