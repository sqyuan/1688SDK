using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class Sender
    {
        /// <summary>
        /// 发货人名称
        /// </summary>
        public string senderName { get; set; }

        /// <summary>
        /// 发货人电话
        /// </summary>
        public string senderPhone { get; set; }

        /// <summary>
        /// 发货人手机
        /// </summary>
        public string senderMobile { get; set; }

        /// <summary>
        /// 地区编码规范（CN、GB）
        /// </summary>
        public string encrypt { get; set; }
        /// <summary>
        /// 发货人省地区编码
        /// </summary>
        public string senderProvinceCode { get; set; }

        /// <summary>
        /// 发货人市地区编码
        /// </summary>
        public string senderCityCode { get; set; }

        /// <summary>
        /// 发货人区地区编码
        /// </summary>
        public string senderCountyCode { get; set; }

        /// <summary>
        /// 发货人详细地址
        /// </summary>
        public string senderAddress { get; set; }

        /// <summary>
        /// 发货人省地址
        /// </summary>
        public string senderProvince { get; set; }

        /// <summary>
        /// 发货人市地址
        /// </summary>
        public string senderCity { get; set; }

        /// <summary>
        /// 发货人区地址
        /// </summary>
        public string senderCounty { get; set; }
    }
}
