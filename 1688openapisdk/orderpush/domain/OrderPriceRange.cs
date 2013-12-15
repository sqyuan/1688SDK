using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class OrderPriceRange
    {
        /// <summary>
        /// 起始数量。商品批发价格区间的最低起批量
        /// </summary>
        public int beginAmount { get; set; }

        /// <summary>
        /// 终止数量。商品批发价格区间的最高起批量
        /// </summary>
        public int endAmount { get; set; }

        /// <summary>
        /// 价格。商品批发价格
        /// </summary>
        public double price { get; set; }
    }
}
