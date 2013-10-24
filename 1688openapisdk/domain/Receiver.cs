using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class Receiver
    {
        /// <summary>
        /// 收货人名称
        /// </summary>
        public string receiverName { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        public string receiverPhone { get; set; }

        /// <summary>
        /// 收货人手机
        /// </summary>
        public string receiverMobile { get; set; }

        /// <summary>
        /// 地区编码规范（CN、GB）
        /// </summary>
        public string encrypt { get; set; }
        /// <summary>
        /// 收货人省地区编码
        /// </summary>
        public string receiverProvinceCode { get; set; }

        /// <summary>
        /// 收货人市地区编码
        /// </summary>
        public string receiverCityCode { get; set; }

        /// <summary>
        /// 收货人区地区编码
        /// </summary>
        public string receiverCountyCode { get; set; }

        /// <summary>
        /// 收货人详细地址
        /// </summary>
        public string receiverAddress { get; set; }

        /// <summary>
        /// 收货人省地址
        /// </summary>
        public string receiverProvince { get; set; }

        /// <summary>
        /// 收货人市地址
        /// </summary>
        public string receiverCity { get; set; }

        /// <summary>
        /// 收货人区地址
        /// </summary>
        public string receiverCounty { get; set; }

    }
}
