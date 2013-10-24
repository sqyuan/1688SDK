using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class TraceNode
    {
        /// <summary>
        /// 事件/操作，事件包括：TRANSPORT，SIGN，UNSIGN
        /// </summary>
        public string action { get; set; }

        /// <summary>
        /// 事件发生城市的省市区编码
        /// </summary>
        public string areaCode { get; set; }

        /// <summary>
        /// 地区编码规范（CN、GB）
        /// </summary>
        public string encrypt { get; set; }

        /// <summary>
        /// 流转节点的时间 格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string acceptTime { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 站点类型：1. 网点，2. 中转中心\分拨中心
        /// </summary>
        /// 
        public string facilityType { get; set; }

        /// <summary>
        /// 网点编号
        /// </summary>
        public string facilityNo { get; set; }

        /// <summary>
        /// 网点名称或分拨中心名称
        /// </summary>
        public string facilityName { get; set; }

    }
}
