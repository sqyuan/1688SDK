using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class PriceRanges
    {
        /// <summary>
        /// 最小起订量。
        /// </summary>
        public string range { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string convertPrice { get; set; }

        /// <summary>
        /// 价格。商品批发价格
        /// </summary>
        public string price { get; set; }
    }
}
