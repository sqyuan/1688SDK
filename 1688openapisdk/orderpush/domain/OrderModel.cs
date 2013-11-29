using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.orderpush.domain
{
    public class OrderModel
    {
        /// <summary>
        /// 结果处理状态码  -1：签名错误  0：结果解析出错  1 正确
        /// </summary>
        public int retCode { get; set; }

        /// <summary>
        /// 消息id，这里用订单id作为消息id，根据订单id来去重
        /// </summary>
        public long message_id { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        public OrderMap orderMap { get; set; }

    }
}
