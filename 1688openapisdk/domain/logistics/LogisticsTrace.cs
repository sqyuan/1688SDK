using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class LogisticsTrace
    {
        /// <summary>
        /// 物流编号
        /// </summary>
        public string logisticsId { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        public long orderId { get; set; }

        /// <summary>
        /// 物流公司提供的运单号
        /// </summary>
        public string logisticsBillNo { get; set; }

        /// <summary>
        /// 流转信息列表
        /// </summary>
        public LogisticsStep[] logisticsSteps { get; set; }

        /// <summary>
        /// 物流节点信息列表
        /// </summary>
        public TraceNode[] traceNodeList { get; set; }
    }
}
