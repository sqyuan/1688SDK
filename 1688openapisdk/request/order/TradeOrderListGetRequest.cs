using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.order;
using _1688openapisdk.domain.order;

namespace _1688openapisdk.domain.order
{
    /// <summary>
    /// 本接口查询当前会话会员的交易订单列表
    /// </summary>
    public class TradeOrderListGetRequest : IAliRequest<TradeOrderListGetResponse>
    {
        /// <summary>
        /// 买家会员名，该订单中的买家会员名。sellerMemberId与buyerMemberId至少填写一个。
        /// </summary>
        public string buyerMemberId { get; set; }

        /// <summary>
        /// 卖家会员ID，该订单中的卖家会员名。sellerMemberId与buyerMemberId至少填写一个。
        /// </summary>
        public string sellerMemberId { get; set; }

        /// <summary>
        /// 交易类型，取值范围：担保交易-1,预存款交易-2,ETC境外收单交易-3,即时到帐交易-4,保障金安全交易-5,统一交易流程-6,分阶段交易-7,货到付款交易-8
        /// </summary>
        public string tradeType { get; set; }

        /// <summary>
        /// 订单交易状态，默认为全部交易状态。若值不为空，合法取值列举如下: 担保交易共有5个状态： waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货), waitbuyerreceive(等待买家收货), success(交易成功), cancel(交易取消，违约金等交割完毕); 即时到账交易共有4个状态： waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货),(交易成功), cancel(交易取消，违约金等交割完毕) 分阶段交易包括：waitbuyerpay(等待买家付款), waitsellersend(等待卖家发货), waitbuyerreceive(等待买家收货), success(交易成功), cancel(交易取消，违约金等交割完毕),waitselleract(等待卖家操作),waitbuyerconfirmaction(等待买家确认操作),waitsellerpush(等待卖家推进)
        /// </summary>
        public string orderStatus { get; set; }

        /// <summary>
        /// 页码，取值范围:大于零的整数;默认值为1，即返回第一页数据。
        /// </summary>
        public int pageNO { get; set; }

        /// <summary>
        /// 分页条数，返回订单列表结果集分页条数。取值范围:大于零的整数；最大值：20；默认值：10。
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// 是否查询历史订单，即3个月以前的订单，默认为false，即不查询历史订单
        /// </summary>
        public Boolean isHis { get; set; }

        /// <summary>
        /// 订单中的商品名称
        /// </summary>
        public string productName { get; set; }

        /// <summary>
        /// 订单编号，指定该参数相当于查询订单明细
        /// </summary>
        public long orderId { get; set; }

        /// <summary>
        /// 下单开始时间(进入订单确认页面)，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string createStartTime { get; set; }

        /// <summary>
        /// 下单结束时间（确认订购），格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string createEndTime { get; set; }

        /// <summary>
        /// 订单支付开始时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string payStartTime { get; set; }

        /// <summary>
        /// 订单支付结束时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string payEndTime { get; set; }

        /// <summary>
        /// 订单更新开始时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string modifyStartTime { get; set; }

        /// <summary>
        /// 订单更新结束时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string modifyEndTime { get; set; }

        public string access_token { get; set; }

        string IAliRequest<TradeOrderListGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/trade.order.orderList.get/";
        }

        IDictionary<string, string> IAliRequest<TradeOrderListGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (this.buyerMemberId != null)
            {
                parameters.Add("buyerMemberId", this.buyerMemberId);
            }
            if (this.sellerMemberId != null)
            {
                parameters.Add("sellerMemberId", this.sellerMemberId);
            }
            if (this.tradeType != null)
            {
                parameters.Add("tradeType", this.tradeType);
            }
            if (this.orderStatus != null)
            {
                parameters.Add("orderStatus", this.orderStatus);
            }
            if (this.pageNO != 0)
            {
                parameters.Add("pageNO", this.pageNO.ToString());
            }
            if (this.pageSize != null)
            {
                parameters.Add("pageSize", this.pageSize.ToString());
            }
            if (this.isHis != null)
            {
                parameters.Add("isHis", this.isHis.ToString());
            }
            if (this.productName != null)
            {
                parameters.Add("productName", this.productName);
            }
            if (this.orderId != 0)
            {
                parameters.Add("orderId", this.orderId.ToString());
            }
            if (this.createStartTime != null)
            {
                parameters.Add("createStartTime", this.createStartTime);
            }
            if (this.createEndTime != null)
            {
                parameters.Add("createEndTime", this.createEndTime);
            }
            if (this.payStartTime != null)
            {
                parameters.Add("payStartTime", this.payStartTime);
            }
            if (this.payEndTime != null)
            {
                parameters.Add("payEndTime", this.payEndTime);
            }
            if (this.modifyStartTime != null)
            {
                parameters.Add("modifyStartTime", this.modifyStartTime);
            }
            if (this.modifyEndTime != null)
            {
                parameters.Add("modifyEndTime", this.modifyEndTime);
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<TradeOrderListGetResponse>.Validate()
        {
            if (this.buyerMemberId == null && this.sellerMemberId == null)
            {
                throw new AliException("buyerMemberId or sellerMemberId must not be null");
            }
        }

        object IAliRequest<TradeOrderListGetResponse>.GetReturnType()
        {
            return typeof(List<OrderInfo>);
        }
    }
}
