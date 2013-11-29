using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.orderpush.domain
{
    /// <summary>
    /// 物流信息
    /// </summary>
    public class Logistics
    {
        /// <summary>
        /// 物流编号
        /// </summary>
        public long logisticsId{get;set;}
        /// <summary>
        /// 发货联系人
        /// </summary>
        public string fromContact{get;set;}
        /// <summary>
        /// 发货联系手机
        /// </summary>
        public string fromMobile{get;set;}
        /// <summary>
        /// 发货联系电话
        /// </summary>
        public string fromPhone{get;set;}
        /// <summary>
        /// 发货省编码
        /// </summary>
        public string fromProvince{get;set;}
        /// <summary>
        /// 发货市编码
        /// </summary>
        public string fromCity{get;set;}
        /// <summary>
        /// 发货区编码
        /// </summary>
        public string fromArea{get;set;}
        /// <summary>
        /// 发货街道地址
        /// </summary>
        public string fromAddress{get;set;}
        /// <summary>
        /// 发货地址邮编
        /// </summary>
        public string fromPost{get;set;}
        /// <summary>
        /// 收货联系人
        /// </summary>
        public string toContact{get;set;}
        /// <summary>
        /// 收货联系手机
        /// </summary>
        public string toMobile{get;set;}
        /// <summary>
        /// 收货联系电话
        /// </summary>
        public string toPhone{get;set;}
        /// <summary>
        /// 收货省编码
        /// </summary>
        public string toProvince{get;set;}
        /// <summary>
        /// 收货市编码
        /// </summary>
        public string toCity{get;set;}
        /// <summary>
        /// 收货区编码
        /// </summary>
        public string toArea{get;set;}
        /// <summary>
        /// 收货街道地址
        /// </summary>
        public string toAddress{get;set;}
        /// <summary>
        /// 收货地址邮编
        /// </summary>
        public string toPost{get;set;}
        /// <summary>
        /// 物流公司编号
        /// </summary>
        public string logisticsCompanyNo{get;set;}
        /// <summary>
        /// 快递公司名
        /// </summary>
        public string logisticsCompanyName{get;set;}
        /// <summary>
        /// 物流公司运单号
        /// </summary>
        public string logisticsBillNo{get;set;}
        /// <summary>
        /// 物流单号
        /// </summary>
        public string logisticsOrderNo{get;set;}
        /// <summary>
        /// 发货状态，取值范围,waitsend(等待发货),alreadysend(已发货)
        /// </summary>
        public string status{get;set;}
        /// <summary>
        /// 发货时间
        /// </summary>
        public string gmtSend { get; set; }

    }
}
