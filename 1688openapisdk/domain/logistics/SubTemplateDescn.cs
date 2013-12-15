using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.logistics
{
    /// <summary>
    /// 运费子模板描述
    /// </summary>
    public class SubTemplateDescn
    {
        /// <summary>
        /// 计费方式名称：重量；件数；体积	重量
        /// </summary>
        public string chargeTypeName { get; set; }

        /// <summary>
        /// 计费方式：0:重量；1:件数；2:体积
        /// </summary>
        public int chargeType { get; set; }

        /// <summary>
        /// 运费承担类型：0:买家承担；1:卖家承担
        /// </summary>
        public int serviceChargeType { get; set; }

        /// <summary>
        /// 子模板名称：快递、货运、COD
        /// </summary>
        public string subTemplateName { get; set; }

        /// <summary>
        /// 服务类型：0:快递；1:货运；2:COD
        /// </summary>
        public int serviceType { get; set; }

        /// <summary>
        /// 费率来源：0:自定义；1:使用快递费率
        /// </summary>
        public int rateSourceType { get; set; }

        /// <summary>
        /// 费率描述列表
        /// </summary>
        public DeliveryRateDescn[] rates { get; set; }
    }
}
