using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.orderpush.domain
{
    /// <summary>
    /// 子订单信息
    /// </summary>
    public class OrderEntry
    {
        /// <summary>
        /// 订单明细编号
        /// </summary>
        public long id{get;set;}
        /// <summary>
        /// 商品编号
        /// </summary>
        public long sourceId{get;set;}
        /// <summary>
        /// 产品信息
        /// </summary>
        public OfferModel offerModel{get;set;}
        /// <summary>
        /// 商品图片
        /// </summary>
        public string productPic{get;set;}
        /// <summary>
        /// 商品名称
        /// </summary>
        public string productName{get;set;}
        /// <summary>
        /// 订单明细单价，单位,分
        /// </summary>
        public long price{get;set;}
        /// <summary>
        /// 商品数量
        /// </summary>
        public double quantity{get;set;}
        /// <summary>
        /// 订单明细折扣
        /// </summary>
        public long entryDiscount{get;set;}
        /// <summary>
        /// 订单明细状态，取值范围同订单status
        /// </summary>
        public string entryStatus{get;set;}
        /// <summary>
        /// 订单明细货到付款状态，取值范围同订单codStatus
        /// </summary>
        public int entryCodStatus{get;set;}
        /// <summary>
        /// 产品图片/快照图片
        /// </summary>
        public OfferSnapshotImageUrlList offerSnapshotImageUrlList { get; set; }
        /// <summary>
        /// 退款单ID
        /// </summary>
        public long refundId { get; set; }

    }
}
