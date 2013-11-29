using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.orderpush.domain
{
    /// <summary>
    /// 发票信息
    /// </summary>
    public class InvoiceModel
    {
        /// <summary>
        /// 发票主键
        /// </summary>
        public long invoiceId{get;set;}
        /// <summary>
        /// 发票公司名称
        /// </summary>
        public string invoiceCompanyName{get;set;}
        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public string taxpayerIdentify{get;set;}
        /// <summary>
        /// 公司开户行和帐号
        /// </summary>
        public string bankAndAccount{get;set;}
        /// <summary>
        /// 发票收货地址
        /// </summary>
        public string receiveAddress{get;set;}
        /// <summary>
        /// 发票收货人电话
        /// </summary>
        public string receivePhone { get; set; }

    }
}
