using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.product
{
    public class SkuInfo
    {
        /// <summary>
        /// 属性id
        /// </summary>
        public int fid { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// 该属性下的规格列表
        /// </summary>
        public SkuChild[] children { get; set; }
    }
}
