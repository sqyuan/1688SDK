﻿using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain;

namespace _1688openapisdk.response
{
    public class LogisticsTraceGetResponse:AliResponse
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
        /// 订单中物流单个数
        /// </summary>
        public int totalCount { get; set; }

        /// <summary>
        /// 物流单及跟踪信息列表
        /// </summary>
        public LogisticsTrace[] dataList { get; set; }
    }
}
