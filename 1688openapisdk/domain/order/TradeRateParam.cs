using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.order
{
    /// <summary>
    /// 描述单个订单，卖家对买家的评价信息与星级
    /// </summary>
    public class TradeRateParam
    {
        /// <summary>
        /// 评价信息描述
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 评价星级，1-5
        /// </summary>
        public string starLevel { get; set; }
    }
}
