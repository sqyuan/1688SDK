using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.order;

namespace _1688openapisdk.response.order
{
    public class NewTradeOrderDetailGetResponse:AliResponse
    {
        /// <summary>
        /// 订单结果集
        /// </summary>
        public OrderModel orderModel { get; set; }
    }
}
