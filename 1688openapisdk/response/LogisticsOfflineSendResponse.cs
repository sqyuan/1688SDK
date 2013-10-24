using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.response
{
    public class LogisticsOfflineSendResponse:AliResponse
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
        /// 物流编号
        /// </summary>
        public string logisticsId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// 订单明细，以英文逗号分隔
        /// </summary>
        public string orderEntryIds { get; set; }
    }
}
