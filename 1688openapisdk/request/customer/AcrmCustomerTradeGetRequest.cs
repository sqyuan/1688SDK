using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.customer;
using _1688openapisdk.domain.customer;

namespace _1688openapisdk.request.customer
{
    /// <summary>
    /// 本接口实现阿里巴巴中文站登录会员，根据交易信息获取当前卖家的会员信息
    /// </summary>
    public class AcrmCustomerTradeGetRequest : IAliRequest<AcrmCustomerTradeGetResponse>
    {
        /// <summary>
        /// 卖家ID
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 交易总额下限
        /// </summary>
        public long tradeAmountStart { get; set; }

        /// <summary>
        /// 交易总额上线
        /// </summary>
        public long tradeAmountEnd { get; set; }

        /// <summary>
        /// 交易时间下限
        /// </summary>
        public string lastestTimeStart { get; set; }

        /// <summary>
        /// 交易时间上限
        /// </summary>
        public string lastestTimeEnd { get; set; }

        /// <summary>
        /// 交易笔数下限
        /// </summary>
        public int tradeCountStart { get; set; }

        /// <summary>
        /// 交易笔数上限
        /// </summary>
        public int tradeCountEnd { get; set; }

        /// <summary>
        /// 平均客单价下限
        /// </summary>
        public long avgPriceStart { get; set; }

        /// <summary>
        /// 平均客单价上限
        /// </summary>
        public long avgPriceEnd { get; set; }

        /// <summary>
        /// 累计货品数量下限
        /// </summary>
        public int itemNumStart { get; set; }

        /// <summary>
        /// 累计货品数量上限
        /// </summary>
        public int itemNumEnd { get; set; }

        /// <summary>
        /// 省份，用0-35表示
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 页面大小    最大50
        /// </summary>
        public int pageSize { get; set; }

        public int pageNum { get; set; }

        public string access_token { get; set; }

        string IAliRequest<AcrmCustomerTradeGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/acrm.customer.trade.get/";
        }

        IDictionary<string, string> IAliRequest<AcrmCustomerTradeGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            if (this.tradeAmountStart != 0)
            {
                parameters.Add("tradeAmountStart", this.tradeAmountStart.ToString());
            }
            if (this.tradeAmountEnd != 0)
            {
                parameters.Add("tradeAmountEnd", this.tradeAmountEnd.ToString());
            }
            if (this.tradeCountStart != 0)
            {
                parameters.Add("tradeCountStart", this.tradeCountStart.ToString());
            }
            if (this.tradeCountEnd != 0)
            {
                parameters.Add("tradeCountEnd", this.tradeCountEnd.ToString());
            }
            if (this.avgPriceStart != 0)
            {
                parameters.Add("avgPriceStart", this.avgPriceStart.ToString());
            }
            if (this.avgPriceEnd != 0)
            {
                parameters.Add("avgPriceEnd", this.avgPriceEnd.ToString());
            }
            if (this.pageSize != 0)
            {
                parameters.Add("pageSize", this.pageSize.ToString());
            }
            if (this.pageNum != 0)
            {
                parameters.Add("pageNum", this.pageNum.ToString());
            }
            if (this.lastestTimeStart != null)
            {
                parameters.Add("lastestTimeStart", this.lastestTimeStart);
            }
            if (this.lastestTimeEnd != null)
            {
                parameters.Add("lastestTimeEnd", this.lastestTimeEnd);
            }
            if (this.province != null)
            {
                parameters.Add("province", this.province);
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<AcrmCustomerTradeGetResponse>.Validate()
        {
            if (this.memberId == null)
            {
                throw new AliException("memberId must not be null");
            }
        }

        object IAliRequest<AcrmCustomerTradeGetResponse>.GetReturnType()
        {
            return typeof(List<Relation>);
        }
    }
}
