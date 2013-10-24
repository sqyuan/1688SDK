using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.order;

namespace _1688openapisdk.response.order
{
    public class TradeOrderListGetResponse:AliResponse
    {

        /// <summary>
        /// 订单结果集
        /// </summary>
        public OrderInfo[] toReturn { get; set; }

    }
}
