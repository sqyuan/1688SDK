using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain;

namespace _1688openapisdk.response
{
    public class LogisticsCompaniesGetResponse:AliResponse
    {

        /// <summary>
        /// 请求发货结果编码
        /// </summary>
        public string resultCode { get; set; }

        /// <summary>
        /// 请求返回结果信息
        /// </summary>
        public string resultMsg { get; set; }

        /// <summary>
        /// 一共多少个物流公司
        /// </summary>
        public int totalCount { get; set; }

        /// <summary>
        /// 物流公司列表
        /// </summary>
        public SimpleLogisticsCompany[] dataList { get; set; }
    }
}
