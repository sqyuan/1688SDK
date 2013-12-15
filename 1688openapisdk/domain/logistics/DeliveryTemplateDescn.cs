using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.logistics
{
    /// <summary>
    /// 运费模板描述详情
    /// </summary>
    public class DeliveryTemplateDescn
    {
        /// <summary>
        /// 运费模板ID
        /// </summary>
        public long templateId { get; set; }

        /// <summary>
        /// 运费模板名称
        /// </summary>
        public string templateName { get; set; }

        /// <summary>
        /// 发货省份名称
        /// </summary>
        public string fromProvinceName { get; set; }

        /// <summary>
        /// 发货城市名称
        /// </summary>
        public string fromCityName { get; set; }

        /// <summary>
        /// 发货区县名称
        /// </summary>
        public string fromCountyName { get; set; }

        /// <summary>
        /// 模板备注
        /// </summary>
        public string descn { get; set; }

        /// <summary>
        /// 包含服务类型，0为：快递，1为：货运，2为：COD
        /// </summary>
        public int[] serviceTypes { get; set; }

        /// <summary>
        /// 子模板描述列表
        /// </summary>
        public SubTemplateDescn[] subTemplateDescnList { get; set; }
    }
}
