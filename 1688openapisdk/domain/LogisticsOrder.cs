using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class LogisticsOrder
    {
        /// <summary>
        /// 物流编号
        /// </summary>
        public string logisticsId { get; set; }

        /// <summary>
        /// 物流公司运单号
        /// </summary>
        public string logisticsBillNo { get; set; }

        /// <summary>
        /// 订单明细
        /// </summary>
        public string orderEntryIds { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 物流公司ID
        /// </summary>
        public string logisticsCompanyId { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        public string logisticsCompanyName { get; set; }

        /// <summary>
        /// 用户发货时备注
        /// </summary>
        public string remarks { get; set; }

        /// <summary>
        /// 产品类型和增值服务选择（自行发货、无需物流、在线快递下单该字段为空）
        /// </summary>
        public string ServiceFeature { get; set; }

        /// <summary>
        /// 发货人信息
        /// </summary>
        public Sender sender { get; set; }

        /// <summary>
        /// 收货人信息
        /// </summary>
        public Receiver receiver { get; set; }
        
        /// <summary>
        /// 货物信息列表
        /// </summary>
        public SendGood[] sendGoods { get; set; }

        /// <summary>
        /// 系统发货时间
        /// </summary>
        public string gmtSystemSend { get; set; }
    }
}
