using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.product
{
    public class SkuChild
    {
        /// <summary>
        /// 指定规格的货号
        /// </summary>
        public string cargoNumber { get; set; }

        /// <summary>
        /// 销售量
        /// </summary>
        public int saleCount { get; set; }

        /// <summary>
        /// 建议零售价
        /// </summary>
        public string retailPrice { get; set; }
        /// <summary>
        /// 指定规格的供货总量
        /// </summary>
        public int canBookCount { get; set; }

        /// <summary>
        /// 格报价时该规格的单价
        /// </summary>
        public string price { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        public string specId { get; set; }

        /// <summary>
        /// 规格的属性id
        /// </summary>
        public int fid { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string value { get; set; }

    }
}
