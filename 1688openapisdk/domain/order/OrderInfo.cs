using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.order
{
    public class OrderInfo
    {
        /// <summary>
        /// 卖家评价状态，4-已评价，5-未评价
        /// </summary>
        public string sellerRateStatus { get;set;}

        /// <summary>
        /// 买家评价状态，4-已评价，5-未评价
        /// </summary>
        public string buyerRateStatus { get; set; }

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
        public int tradeType { get; set; }

        /// <summary>
        /// 担保交易共有5个状态： waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货), waitbuyerreceive(等待买家收货), success(交易成功), cancel(交易取消，违约金等交割完毕); 即时到账交易共有4个状态： waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货),(交易成功), cancel(交易取消，违约金等交割完毕) 分阶段交易包括：waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货), waitbuyerreceive(等待买家收货), success(交易成功), cancel(交易取消，违约金等交割完毕),waitselleract(等待卖家操作),waitbuyerconfirmaction(等待买家确认操作),waitsellerpush(等待卖家推进)
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 买家下单时间，即订单创建时间
        /// </summary>
        public string gmtCreate { get; set; }

        /// <summary>
        /// 买家付款时间
        /// </summary>
        public string gmtPayment { get; set; }

        /// <summary>
        /// 运费，单位：分
        /// </summary>
        public string carriage { get; set; }

        /// <summary>
        /// 涨价或折扣，折扣为负数（单位:分）
        /// </summary>
        public double discount { get; set; }

        /// <summary>
        /// 货品总价+运费=实付款（单位:分）
        /// </summary>
        public long sumPayment { get; set; }

        /// <summary>
        /// 抵价券实际消费金额（单位:分）
        /// </summary>
        public string couponAmount { get; set; }

        /// <summary>
        /// 收货人所在地区
        /// </summary>
        public string toArea { get; set; }

        /// <summary>
        /// 收货人邮编
        /// </summary>
        public string toPost { get; set; }

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
        public Logistics[] logistics;
        
        /// <summary>
        /// 卖家邮箱
        /// </summary>
        public string sellerEmail { get; set; }

        /// <summary>
        /// 交易最后修改时间
        /// </summary>
        public string gmtModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long buyerUserId { get; set; }

        public long sellerUserId { get; set; }

        /// <summary>
        /// 卖家支付宝ID
        /// </summary>
        public string sellerAlipayId { get; set; }


        public long sumProductPayment { get; set; }

        /// <summary>
        /// 买家留言
        /// </summary>
        public string buyerFeedback { get; set; }

        /// <summary>
        /// 卖家公司名
        /// </summary>
        public string sellerCompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string buyerEmail { get; set; }

        /// <summary>
        /// 卖家电话
        /// </summary>
        public string sellerPhone { get; set; }

        /// <summary>
        /// 买家支付宝ID
        /// </summary>
        public string buyerAlipayId { get; set; }

        /// <summary>
        /// 买家手机号
        /// </summary>
        public string buyerMobile { get; set; }

        /// <summary>
        /// 卖家发货时间
        /// </summary>
        public string gmtGoodsSend { get; set; }

        /// <summary>
        /// 买家电话
        /// </summary>
        public string buyerPhone { get; set; }

        /// <summary>
        /// 退款金额，单位：分
        /// </summary>
        public long refundPayment { get; set; }
    }
}
