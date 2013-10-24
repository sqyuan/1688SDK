using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.order
{
    public class Logistics
    {
        /// <summary>
        /// 物流公司运单号
        /// </summary>
        public string logisticsBillNo { get; set; }

        /// <summary>
        /// 订单状态，取值范围：waitbuyerpay（等待买家付款），waitsellersend（等待卖家发货），waitbuyerreceive（等待买家确认收货），success（交易成功），cancel（交易关闭），waitbuyerconfirm（分队段等待买家确认，waitselleract（分阶段等待卖家处理），waitbuyerconfirmaction（分阶段等待买家确认动作），waitsellerpush（分阶段卖家推进），waitlogisticstakein（等待物流公司揽件），waitbuyersign（等待买家签收），signinsuccess（买家已签收），signinfailed（签收失败）
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 发货联系人
        /// </summary>
        public string fromContact { get; set; }

        /// <summary>
        /// 收货地址邮编
        /// </summary>
        public string toPost { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        public string logisticsOrderNo { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        public string gmtSend { get; set; }

        /// <summary>
        /// 收货区
        /// </summary>
        public string toArea { get; set; }

        /// <summary>
        /// 收货市
        /// </summary>
        public string toCity { get; set; }

        /// <summary>
        /// 收货省
        /// </summary>
        public string toProvince { get; set; }

        /// <summary>
        /// 收货街道地址
        /// </summary>
        public string toAddress { get; set; }

        /// <summary>
        /// 物流编号
        /// </summary>
        public long logisticsId { get; set; }

        /// <summary>
        /// 快递公司名
        /// </summary>
        public string logisticsCompanyName { get; set; }

        /// <summary>
        /// 发货联系电话
        /// </summary>
        public string fromPhone { get; set; }

        /// <summary>
        /// 发货街道地址
        /// </summary>
        public string fromAddress { get; set; }

        /// <summary>
        /// 发货区
        /// </summary>
        public string fromArea { get; set; }

        /// <summary>
        /// 发货市
        /// </summary>
        public string fromCity { get; set; }

        /// <summary>
        /// 发货联系手机
        /// </summary>
        public string fromMobile { get; set; }


        /// <summary>
        /// 发货地址邮编
        /// </summary>
        public string fromPost { get; set; }

        /// <summary>
        /// 发货省
        /// </summary>
        public string fromProvince { get; set; }

        /// <summary>
        /// 收货联系手机
        /// </summary>
        public string toMobile { get; set; }

        /// <summary>
        /// 收货联系人
        /// </summary>
        public string toContact { get; set; }

        /// <summary>
        /// 物流公司编号
        /// </summary>
        public string logisticsCompanyNo { get; set; }

    }
}
