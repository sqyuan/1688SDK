using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.order;

namespace _1688openapisdk.request.order
{
    /// <summary>
    /// 新版查询订单列表，不包含用户的隐私数据；适用于查询卖家和买家的订单列表 trade.order.list.get -- version: 2
    /// </summary>
    public class NewTradeOrderListGetRequest : IAliRequest<NewTradeOrderListGetResponse>
    {
        /// <summary>
        /// 是否查询历史订单，即3个月以前的订单，默认为false，即不查询历史订单
        /// </summary>
        public Boolean his { get; set; }
        /// <summary>
        /// 下单开始时间(进入订单确认页面)，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string createStartTime { get; set; }

        /// <summary>
        /// 下单结束时间（确认订购），格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string createEndTime { get; set; }
        /// <summary>
        /// 买家会员名，该订单中的买家会员名。sellerMemberId与buyerMemberId至少填写一个。
        /// </summary>
        public string buyerMemberId { get; set; }

        /// <summary>
        /// 卖家会员ID，该订单中的卖家会员名。sellerMemberId与buyerMemberId至少填写一个。
        /// </summary>
        public string sellerMemberId { get; set; }

        /// <summary>
        /// 订单中的商品名称
        /// </summary>
        public string productName { get; set; }

        /// <summary>
        /// 订单支付开始时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string payStartTime { get; set; }

        /// <summary>
        /// 订单支付结束时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string payEndTime { get; set; }


        /// <summary>
        /// 订单类型	UNIFY（普通），STEP（分阶段）
        /// </summary>
        public string tradeTypeEnum { get; set; }

        /// <summary>
        /// 订单状态	SUCCESS，CANCEL，WAIT_BUYER_PAY，WAIT_SELLER_SEND，WAIT_BUYER_RECEIVE
        /// </summary>
        public string orderStatusEnum { get; set; }

        /// <summary>
        /// 页码，取值范围:大于零的整数;默认值为1，即返回第一页数据。
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// 分页条数，返回订单列表结果集分页条数。取值范围:大于零的整数；最大值：20；默认值：10。
        /// </summary>
        public int pageSize { get; set; }


        /// <summary>
        /// 订单更新开始时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string modifyStartTime { get; set; }

        /// <summary>
        /// 订单更新结束时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string modifyEndTime { get; set; }

        public string access_token { get; set; }


        string IAliRequest<NewTradeOrderListGetResponse>.GetApiName()
        {
            return "param2/2/cn.alibaba.open/trade.order.list.get/";
        }

        IDictionary<string, string> IAliRequest<NewTradeOrderListGetResponse>.GetParameters()
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
            if (this.tradeTypeEnum != null)
            {
                parameters.Add("tradeTypeEnum", this.tradeTypeEnum);
            }
            if (this.orderStatusEnum != null)
            {
                parameters.Add("orderStatusEnum", this.orderStatusEnum);
            }
            if (this.page != 0)
            {
                parameters.Add("page", this.page.ToString());
            }
            if (this.pageSize != null)
            {
                parameters.Add("pageSize", this.pageSize.ToString());
            }
            if (this.his != null)
            {
                parameters.Add("his", this.his.ToString());
            }
            if (this.productName != null)
            {
                parameters.Add("productName", this.productName);
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

        void IAliRequest<NewTradeOrderListGetResponse>.Validate()
        {
            if (this.buyerMemberId == null && this.sellerMemberId == null)
            {
                throw new AliException("buyerMemberId or sellerMemberId must not be null");
            }
        }

        object IAliRequest<NewTradeOrderListGetResponse>.GetReturnType()
        {
            return typeof(NewTradeOrderListGetResponse);
        }
    }
}
