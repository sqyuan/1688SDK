using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.order;
using _1688openapisdk.domain.order;

namespace _1688openapisdk.domain.order
{
    /// <summary>
    /// 本接口实现获取指定会员在阿里巴巴中文站上的物流模板列表信息
    /// </summary>
    public class TradeFreightTemplateListGetRequest : IAliRequest<TradeFreightTemplateListGetResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string memberId { get; set; }

        public string access_token { get; set; }

        string IAliRequest<TradeFreightTemplateListGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/trade.freight.freightTemplateList.get/";
        }

        IDictionary<string, string> IAliRequest<TradeFreightTemplateListGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (this.memberId != null)
            {
                parameters.Add("memberId", this.memberId);
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<TradeFreightTemplateListGetResponse>.Validate()
        {
            if (this.memberId == null)
            {
                throw new AliException("memberId must not be null");
            }
        }

        object IAliRequest<TradeFreightTemplateListGetResponse>.GetReturnType()
        {
            return typeof(List<FreightTemplate>);
        }
    }
}
