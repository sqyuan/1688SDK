using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.orderpush.domain
{
    /// <summary>
    /// 分阶段付款信息
    /// </summary>
    public class StepOrder
    {
        /// <summary>
        /// 阶段id
        /// </summary>
        public long stepOrderId{get;set;}
        /// <summary>
        /// 阶段状态，取值范围：waitactivate(未开始),waitsellerpush(等待卖家推进),success(本阶段完成),cancel(本阶段终止),inactiveandcancel(本阶段未开始便终止),waitbuyerpay(等待买家付款),waitsellersend(等待卖家发货),waitbuyerreceive(等待买家确认收货),waitselleract(等待卖家操作),waitbuyerconfirmaction(等待买家确认操作)
        /// </summary>
        public string stepOrderStatus{get;set;}
        /// <summary>
        /// 支付状态，取值范围,1(未付款),2(已付款),4(已退款),6(交易成功),8(交易未付款被关闭)
        /// </summary>
        public int stepPayStatus{get;set;}
        /// <summary>
        /// 阶段序列
        /// </summary>
        public long stepNo{get;set;}
        /// <summary>
        /// 是否最后一个阶段
        /// </summary>
        public Boolean lastStep{get;set;}
        /// <summary>
        /// 是否已打款给卖家
        /// </summary>
        public Boolean hasDisbursed{get;set;}
        /// <summary>
        /// 创建时需要付款的金额，不含运费
        /// </summary>
        public long payFee{get;set;}
        /// <summary>
        /// 应付款（含运费）
        /// </summary>
        public long actualPayFee{get;set;}
        /// <summary>
        /// 本阶段分摊的店铺优惠
        /// </summary>
        public long discountFee{get;set;}
        /// <summary>
        /// 本阶段分摊的单品优惠
        /// </summary>
        public long itemDiscountFee{get;set;}
        /// <summary>
        /// 本阶段分摊的单价
        /// </summary>
        public long price{get;set;}
        /// <summary>
        /// 购买数量
        /// </summary>
        public long  amount{get;set;}
        /// <summary>
        /// 运费
        /// </summary>
        public long postFee{get;set;}
        /// <summary>
        /// 修改价格修改的金额
        /// </summary>
        public long adjustFee{get;set;}
        /// <summary>
        /// 创建时间
        /// </summary>
        public string gmtCreate{get;set;}
        /// <summary>
        /// 修改时间
        /// </summary>
        public string gmtModified{get;set;}
        /// <summary>
        /// 开始时间
        /// </summary>
        public string enterTime{get;set;}
        /// <summary>
        /// 付款时间
        /// </summary>
        public string payTime{get;set;}
        /// <summary>
        /// 卖家操作时间
        /// </summary>
        public string sellerActionTime{get;set;}
        /// <summary>
        /// 本阶段结束时间
        /// </summary>
        public string endTime{get;set;}
        /// <summary>
        /// 卖家操作留言路径
        /// </summary>
        public string messagePath{get;set;}
        /// <summary>
        /// 卖家上传图片凭据路径
        /// </summary>
        public string picturePath{get;set;}
        /// <summary>
        /// 卖家操作留言
        /// </summary>
        public string message{get;set;}
        /// <summary>
        /// 使用的模板id
        /// </summary>
        public long  templateId{get;set;}
        /// <summary>
        /// 当前步骤的名称
        /// </summary>
        public string stepName{get;set;}
        /// <summary>
        /// 卖家操作名称
        /// </summary>
        public string sellerActionName{get;set;}
        /// <summary>
        /// 买家不付款的超时时间(秒)
        /// </summary>
        public long  buyerPayTimeout{get;set;}
        /// <summary>
        /// 买家不确认的超时时间
        /// </summary>
        public long  buyerConfirmTimeout{get;set;}
        /// <summary>
        /// 是否需要物流
        /// </summary>
        public Boolean needLogistics{get;set;}
        /// <summary>
        /// 是否需要卖家操作和买家确认
        /// </summary>
        public Boolean needSellerAction{get;set;}
        /// <summary>
        /// 阶段结束是否打款
        /// </summary>
        public Boolean transferAfterConfirm{get;set;}
        /// <summary>
        /// 是否需要卖家推进
        /// </summary>
        public Boolean needSellerCallNext{get;set;}
        /// <summary>
        /// 是否允许即时到帐
        /// </summary>
        public Boolean instantPay { get; set; }

    }
}
