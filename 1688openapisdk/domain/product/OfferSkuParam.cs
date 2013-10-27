using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.product
{
    public class OfferSkuParam
    {
        /// <summary>
        /// 指定规格的货号
        /// </summary>
        public string cargoNumber { get; set; }

        /// <summary>
        /// 指定规格的供货总量
        /// </summary>
        public int amountOnSale { get; set; }

        /// <summary>
        /// 建议零售价
        /// </summary>
        public Double retailPrice { get; set; }

        /// <summary>
        /// 格报价时该规格的单价
        /// </summary>
        public Double price { get; set; }

        /// <summary>
        /// 特殊规格	{"3216":"A 1cm宽","450":"均码"}
        /// </summary>
        public Dictionary<String, String> specAttributes { get; set; }

    }
}
