using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.orderpush.domain
{
    public class OrderMap
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public long id{get;set;}
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        public string alipayTradeId{get;set;}
        /// <summary>
        /// 卖家支付宝ID
        /// </summary>
        public string sellerAlipayId{get;set;}
        /// <summary>
        /// 卖家公司名
        /// </summary>
        public string sellerCompanyName{get;set;}
        /// <summary>
        /// 卖家会员登录名，即会员id
        /// </summary>
        public string sellerMemberId{get;set;}
        /// <summary>
        /// 卖家电话
        /// </summary>
        public string sellerPhone{get;set;}
        /// <summary>
        /// 卖家手机号
        /// </summary>
        public string sellerMobile{get;set;}
        /// <summary>
        /// 卖家邮箱
        /// </summary>
        public string sellerEmail{get;set;}
        /// <summary>
        /// 买家会员登录名，即会员id
        /// </summary>
        public string  buyerMemberId{get;set;}
        /// <summary>
        /// 买家公司名
        /// </summary>
        public string buyerCompanyName{get;set;}
        /// <summary>
        /// 买家登录ID，旺旺id号，loginId  5-25
        /// </summary>
        public string buyerLoginId{get;set;}
        /// <summary>
        /// 买家联系地址国家名称 64
        /// </summary>
        public string buyerComapnyAddressCountry{get;set;}
        /// <summary>
        /// 买家联系地址省份名称 128
        /// </summary>
        public string buyerComapnyAddressProvince{get;set;}
        /// <summary>
        /// 买家联系地址城市名称  128
        /// </summary>
        public string buyerComapnyAddressCity{get;set;}
        /// <summary>
        /// 买家联系地址街道地址  256
        /// </summary>
        public string buyerComapnyAddressStreet{get;set;}
        /// <summary>
        /// 买家公司注册地 128
        /// </summary>
        public string buyerFoundedPlace{get;set;}
        /// <summary>
        /// 买家支付宝ID
        /// </summary>
        public string buyerAlipayId{get;set;}
        /// <summary>
        /// 买家电话
        /// </summary>
        public string buyerPhone{get;set;}
        /// <summary>
        /// 买家手机号
        /// </summary>
        public string buyerMobile{get;set;}
        /// <summary>
        /// 买家email
        /// </summary>
        public string buyerEmail{get;set;}
        /// <summary>
        /// 1：支付宝担保交易 4：即时到帐交易
        /// </summary>
        public int tradeType{get;set;}
        /// <summary>
        /// 合法取值列举如下： 担保交易共有5个状态，分别是： waitbuyerpay waitsellersend waitbuyerreceive success cancel 即时到账交易共有4个状态，分别是： waitbuyerpay waitsellersend success cancel
        /// </summary>
        public string status{get;set;}
        /// <summary>
        /// 买家下单时间，即订单创建时间
        /// </summary>
        public string gmtCreate{get;set;}
        /// <summary>
        /// 买家付款时间
        /// </summary>
        public string gmtPayment{get;set;}
        /// <summary>
        /// 卖家发货时间
        /// </summary>
        public string gmtGoodsSend{get;set;}
        /// <summary>
        /// 交易完成时间
        /// </summary>
        public string gmtCompleted{get;set;}
        /// <summary>
        /// 交易最后修改时间
        /// </summary>
        public string gmtModified{get;set;}
        /// <summary>
        /// 产品总金额
        /// </summary>
        public long sumProductPayment{get;set;}
        /// <summary>
        /// 运费
        /// </summary>
        public long carriage{get;set;}
        /// <summary>
        /// 订单优惠金额
        /// </summary>
        public long discount{get;set;}
        /// <summary>
        /// 订单付款总额
        /// </summary>
        public long sumPayment{get;set;}
        /// <summary>
        /// 买家留言
        /// </summary>
        public string buyerFeedback{get;set;}
        /// <summary>
        /// 退款金额，单位分
        /// </summary>
        public long refundPayment{get;set;}
        /// <summary>
        /// 退款状态，取值范围,waitselleragree(等待卖家同意),refundsuccess(退款成功),refundclose(退款关闭),waitbuyermodify(待买家修改),waitbuyersend(等待买家退货),waitsellerreceive(等待卖家确认收货)
        /// </summary>
        public string refundStatus{get;set;}
        /// <summary>
        /// 订单关闭原因
        /// </summary>
        public string closeReason{get;set;}
        /// <summary>
        /// 买家评价状态，取值范围,4(已评论),5(未评论),6(不需要评论)
        /// </summary>
        public int buyerRateStatus{get;set;}
        /// <summary>
        /// 卖家评价状态，取值范围,4(已评论),5(未评论),6(不需要评论)
        /// </summary>
        public int sellerRateStatus{get;set;}
        /// <summary>
        /// 子订单列表
        /// </summary>
        public OrderEntryList orderEntryList { get; set; }

        /// <summary>
        /// 物流单列表
        /// </summary>
        public Logistics[] logisticsList { get; set; }

        /// <summary>
        /// 发票
        /// </summary>
        public InvoiceModel invoiceModel { get; set; }

        /// <summary>
        /// 买家备忘
        /// </summary>
        public Memo buyerMemo { get; set; }


        /// <summary>
        /// 卖家备忘
        /// </summary>
        public Memo sellerMemo { get; set; }
        /// <summary>
        /// 是否一次性付款
        /// </summary>
        public Boolean stepPayAll{get;set;}
        /// <summary>
        /// 订单支付状态，取值范围：1(未付款),2(已付款),4(已退款),6(交易成功),8(交易未付款被关闭)
        /// </summary>
        public int payStatus{get;set;}
        /// <summary>
        /// 订单物流状态，取值范围：1(未发货),2(已发货),3(已收货),4(已经退货),5(部分发货),8(还未创建物流订单)
        /// </summary>
        public int logisticsStatus{get;set;}
        /// <summary>
        /// 分阶段协议地址URL
        /// </summary>
        public string stepAgreementPath { get; set; }
        /// <summary>
        /// 分阶段付款列表
        /// </summary>
        public StepOrder[] stepOrderList { get; set; }
        /// <summary>
        /// 交易的实付款
        /// </summary>
        public long codActualFeedCod{ get; set; }
        /// <summary>
        /// 是否COD订单并且清算成功
        /// </summary>
        public Boolean codAudit{ get; set; }
        /// <summary>
        /// 买家承担的服务费
        /// </summary>
        public long codBuyerFee{ get; set; }
        /// <summary>
        /// 买家承担的服务费初始值
        /// </summary>
        public long codBuyerInitFee{ get; set; }
        /// <summary>
        /// 服务费
        /// </summary>
        public long codFeecod{ get; set; }
        /// <summary>
        /// 三家分润
        /// </summary>
        public string codFeeDividendcod{ get; set; }
        /// <summary>
        /// 买家签收时间
        /// </summary>
        public string codGmtSign{ get; set; }
        /// <summary>
        /// cod服务费初始值
        /// </summary>
        public long  codInitFee{ get; set; }
        /// <summary>
        /// 卖家承担的服务费
        /// </summary>
        public long codSellerFee{ get; set; }
        /// <summary>
        /// COD物流状态，取值范围：0(初始值),20(接单),-20(不接单),2(接单超时),30(揽收成功),-30(揽收失败),3(揽收超时),100(签收成功),-100(签收失败),10(订单等候发送给物流公司),-1(用户取消物流订单)
        /// </summary>
        public int codStatus { get; set; }

    }
}
