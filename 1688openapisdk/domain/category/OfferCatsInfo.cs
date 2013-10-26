using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    /// 发布类目信息
    /// </summary>
    public class OfferCatsInfo
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        public int catsId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        public string catsName { get; set; }

        /// <summary>
        /// 发布类型。1=product=产品，2=process=加工，3=agent=代理，4=cooperation=合作，5=business=商务服务
        /// </summary>
        public int tradeType { get; set; }

        /// <summary>
        /// 是否叶子类目
        /// </summary>
        public Boolean leaf { get; set; }

        /// <summary>
        /// 类目描述
        /// </summary>
        public string catsDescription { get; set; }

        /// <summary>
        /// 父类目数组，包含order与parentCatsId两个元素
        /// </summary>
        public ParentCatInfo[] parentCats { get; set; }

        /// <summary>
        /// 父类目排序号
        /// </summary>
        public int order { get; set; }

        /// <summary>
        /// 是否支持SKU报价
        /// </summary>
        public Boolean supportSKUPrice { get; set; }

        /// <summary>
        /// 是否支持网上订购
        /// </summary>
        public Boolean supportOnlineTrade { get; set; }

        /// <summary>
        /// 是否支持混批
        /// </summary>
        public Boolean supportMixWholesale { get; set; }
    }
}
