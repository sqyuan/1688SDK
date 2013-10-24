using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class ProductFeatureInfo
    {
        /// <summary>
        /// 属性ID。版本1不支持返回属性ID
        /// </summary>
        public int fid { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 属性值列表。版本1不支持返回属性值ID
        /// </summary>
        public string[] values { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string value { get; set; }
    }
}
