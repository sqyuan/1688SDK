using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.order
{
    public class OrderInvoiceModel
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public long orderId { get; set; }

        /// <summary>
        /// 发票公司名称
        /// </summary>
        public string invoiceCompanyName { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public string taxpayerIdentify { get; set; }

        /// <summary>
        /// 公司开户行和帐号
        /// </summary>
        public string bankAndAccount { get; set; }
    }
}
