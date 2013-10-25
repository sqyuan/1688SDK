using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    ///  类目产品属性信息  
    /// </summary>
    public class ProductAttributesInfo
    {
        /// <summary>
        /// 产品属性ID
        /// </summary>
        public int fid { get; set; }

        /// <summary>
        /// 产品属性单位
        /// </summary>
        public string unit { get; set; }

        /// <summary>
        /// 产品属性枚举值。当‘填写类型’为单选或者多选时，该变量有效。多个枚举值之间使用;号（半角分号）分隔
        /// </summary>
        public string values { get; set; }

        /// <summary>
        /// 填写输入的长度限制，比如‘30’。若无限制，则返回null
        /// </summary>
        public int inputMaxLength { get; set; }

        /// <summary>
        /// 产品属性名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 填写类型枚举值。 -1: 数字输入框; 0: 文本输入框（input）;1=下拉（list_box）;2=多选（check_box）;3=单选（radio）
        /// </summary>
        public string showType { get; set; }

        /// <summary>
        /// 该属性是否为必填项。true：必填；false：非必填
        /// </summary>
        public Boolean required { get; set; }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int order { get; set; }

        /// <summary>
        /// 交易Flag
        /// </summary>
        public string fieldFlag { get; set; }

        /// <summary>
        /// 属性类型。0:产品属性 3:交易属性 5:SPU属性
        /// </summary>
        public string aspect { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string note { get; set; }

        /// <summary>
        /// Offer类型。2:供应
        /// </summary>
        public string offerType { get; set; }

        /// <summary>
        /// 引导文案
        /// </summary>
        public string precomment { get; set; }

        /// <summary>
        /// 默认的属性值ID
        /// </summary>
        public string defaultValueId { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string defaultValue { get; set; }

        /// <summary>
        /// 属性值ID
        /// </summary>
        public long[] valueIds { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        public long categoryId { get; set; }

        /// <summary>
        /// 是否关键属性
        /// </summary>
        public Boolean keyAttr { get; set; }

        /// <summary>
        /// 是否规格属性
        /// </summary>
        public Boolean specAttr { get; set; }

        /// <summary>
        /// 是否输入建议框
        /// </summary>
        public Boolean suggestType { get; set; }

        /// <summary>
        /// 是否支持自定义属性
        /// </summary>
        /// 
        public Boolean supportDefinedValues { get; set; }

        /// <summary>
        /// 是否是规格扩展属性（和规格属性相关的属性，目前包括：价格、可售数量、建议零售价、已售数量）
        /// </summary>
        public Boolean specExtendedAttr { get; set; }

    }
}
