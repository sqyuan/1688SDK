using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    /// SPU对象信息
    /// </summary>
    public class StandardSpuAttrValues
    {
        /// <summary>
        /// 属性ID
        /// </summary>
        public int fid { get; set; }

        /// <summary>
        /// 属性单位
        /// </summary>
        public string unit { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 该属性是否为关键属性
        /// </summary>
        public Boolean key { get; set; }
    }
}
