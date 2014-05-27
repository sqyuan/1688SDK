using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.order
{
    /// <summary>
    /// 订单列表返回集
    /// </summary>
    public class OrderListResult
    {
        public int totalCount { get; set; }

        public OrderModel[] modelList { get; set; }
    }
}
