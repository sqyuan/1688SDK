using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class SendGood
    {
        /// <summary>
        /// 货品名称
        /// </summary>
        public string goodName { get; set; }

        /// <summary>
        /// 货品数量
        /// </summary>
        public double quantity { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string unit { get; set; }
    }
}
