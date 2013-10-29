using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.product
{
    public class OfferModifyIncrement
    {
        /// <summary>
        /// 产品id
        /// </summary>
        public string offerId{get;set;}

        /// <summary>
        /// 产品标题
        /// </summary>
        public string subject{get;set;}
        /// <summary>
        /// 价格区间 最多三个，如果产品不是sku产品，则设置该参数,格式为：20:10`30:9`40:8
        /// </summary>
        public string priceRanges {get;set;}

        /// <summary>
        /// sku报价信息，如果产品是sku产品，则设置该参数
        /// </summary>
        public OfferSkuParam[] skuList{get;set;}
    }
}
