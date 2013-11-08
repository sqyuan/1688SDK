using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.order
{
    public class OrderModel
    {

        /// <summary>
        /// 担保交易共有5个状态： waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货), waitbuyerreceive(等待买家收货), success(交易成功), cancel(交易取消，违约金等交割完毕); 即时到账交易共有4个状态： waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货),(交易成功), cancel(交易取消，违约金等交割完毕) 分阶段交易包括：waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货), waitbuyerreceive(等待买家收货), success(交易成功), cancel(交易取消，违约金等交割完毕),waitselleract(等待卖家操作),waitbuyerconfirmaction(等待买家确认操作),waitsellerpush(等待卖家推进)
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 交易最后修改时间
        /// </summary>
        public string gmtModified { get; set; }

        /// <summary>
        /// 买家下单时间，即订单创建时间
        /// </summary>
        public string gmtCreate { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        public string refundStatus { get; set; }
        /// <summary>
        /// 卖家评价状态，4-已评价，5-未评价
        /// </summary>
        public string sellerRateStatus { get;set;}

        /// <summary>
        /// 买家评价状态，4-已评价，5-未评价
        /// </summary>
        public string buyerRateStatus { get; set; }


        /// <summary>
        /// 买家付款时间
        /// </summary>
        public string gmtPayment { get; set; }

        /// <summary>
        /// 卖家发货时间
        /// </summary>
        public string gmtGoodsSend { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        public string gmtConfirmed { get; set; }

        /// <summary>
        /// 运费，单位：分
        /// </summary>
        public string carriage { get; set; }

        /// <summary>
        /// 涨价或折扣，折扣为负数（单位:分）
        /// </summary>
        public double discount { get; set; }

        /// <summary>
        /// 退款金额，单位：分
        /// </summary>
        public long refundPayment { get; set; }


        /// <summary>
        /// 货品总价+运费=实付款（单位:分）
        /// </summary>
        public long sumPayment { get; set; }

        /// <summary>
        /// 关闭原因
        /// </summary>
        public string closeReason { get; set; }
        /// <summary>
        /// 买家留言
        /// </summary>
        public string buyerFeedback { get; set; }
        /// <summary>
        /// 收货人所在地区
        /// </summary>
        public string toArea { get; set; }

        /// <summary>
        /// 收货人邮编
        /// </summary>
        public string toPost { get; set; }



        /// <summary>
        /// 抵价券实际消费金额（单位:分）
        /// </summary>
        public string couponAmount { get; set; }



        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string toFullName { get; set; }

        /// <summary>
        /// 收货人手机
        /// </summary>
        public string toMobile { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        public string toPhone { get; set; }

        /// <summary>
        /// 子订单详情
        /// </summary>
        public OrderEntry[] orderEntries { get; set; }


        ///以下字段是订单详情才会返回的字段
        public Logistics[] logisticsOrderList;

        /// <summary>
        /// 备注列表
        /// </summary>
        public OrderMemoModel[] orderMemoList;

        /// <summary>
        /// 
        /// </summary>
        public OrderInvoiceModel orderInvoiceModel;

        //stepOrderList

        /// <summary>
        /// 是否一次性付款
        /// </summary>
        public Boolean stepPayAll { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        public int payStatus { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        public int logisticsStatus { get; set; }

        /// <summary>
        /// 分阶段协议地址
        /// </summary>
        public string stepAgreementPath { get; set; }

        /// <summary>
        /// cod状态
        /// </summary>
        public int codStatus { get; set; }

        /// <summary>
        /// 是否COD订单并且清算成功
        /// </summary>
        public Boolean codAudit { get; set; }

        /// <summary>
        /// cod服务费
        /// </summary>
        public long codFee { get; set; }

        /// <summary>
        /// 买家承担的服务费
        /// </summary>
        public long codBuyerFee { get; set; }

        /// <summary>
        /// 卖家承担的服务费
        /// </summary>
        public long codSellerFee { get; set; }

        /// <summary>
        /// cod交易的实付款（买家实际支付给物流的费用）
        /// </summary>
        public long codActualFee { get; set; }

        /// <summary>
        /// 买家签收时间(COD)
        /// </summary>
        public string gmtSign { get; set; }

        /// <summary>
        /// cod三家分润
        /// </summary>
        public string codFeeDividend { get; set; }

        /// <summary>
        /// cod服务费初始值
        /// </summary>
        public long codInitFee { get; set; }

        /// <summary>
        /// 买家承担的服务费初始值
        /// </summary>
        public long codBuyerInitFee { get; set; }

        /// <summary>
        /// 买家备注
        /// </summary>
        public OrderMemoModel buyerOrderMemo { get; set; }

        /// <summary>
        /// 卖家备注
        /// </summary>
        public OrderMemoModel sellerOrderMemo { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        public string alipayTradeId { get; set; }

        /// <summary>
        /// 卖家会员登录名，即会员id
        /// </summary>
        public string sellerMemberId { get; set; }

        /// <summary>
        /// 买家会员登录名，即会员id
        /// </summary>
        public string buyerMemberId { get; set; }

        /// <summary>
        /// 1：担保交易，2：预付款交易，3：ETC境外收单交易，4：及时到账交易，5：保障金安全交易，6：统一交易流程，7：分阶段交易，8：货到付款交易，9：信用凭证支付交易
        /// </summary>
        public string tradeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long buyerUserId { get; set; }

        public long sellerUserId { get; set; }

        /// <summary>
        /// 卖家支付宝ID
        /// </summary>
        public string sellerAlipayId { get; set; }

        /// <summary>
        /// 总货品金额
        /// </summary>
        public long sumProductPayment { get; set; }



        /// <summary>
        /// 卖家公司名
        /// </summary>
        public string sellerCompanyName { get; set; }

        /// <summary>
        /// 买家支付宝ID
        /// </summary>
        public string buyerAlipayId { get; set; }

        /// <summary>
        /// 卖家登录id
        /// </summary>
        public string sellerLoginId { get; set; }

        /// <summary>
        /// 买家登录id
        /// </summary>
        public string buyerLoginId { get; set; }

        /// <summary>
        /// 交易类型string
        /// </summary>
        public string tradeTypeStr { get; set; }
    }
}
