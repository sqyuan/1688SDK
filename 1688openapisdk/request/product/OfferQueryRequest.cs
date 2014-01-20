using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;
using _1688openapisdk.domain;

namespace _1688openapisdk.request
{
    /// <summary>
    /// 获取单个产品信息
    /// </summary>
    public class OfferQueryRequest : IAliRequest<OfferResponse>
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        public long offerId { get; set; }
        /// <summary>
        /// 自定义返回字段，字段为offerDetailInfo子集。多个字段以半角','分隔。其中如下参数无法通过该API获得：amountOnSale、details、detailsUrl、saledCount、skuArray、termOfferProcess、tradingType
        /// </summary>
        public string[] returnFields { get; set; }

        //public string access_token { get; set; }


        string IAliRequest<OfferResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.get/";
        }

        IDictionary<string, string> IAliRequest<OfferResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerId", this.offerId.ToString());
            parameters.Add("returnFields", String.Join(",", this.returnFields));
            //parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<OfferResponse>.Validate()
        {
            if (this.offerId == null || this.returnFields == null)
            {
                throw new AliException("offerId , returnFields must not be null");
            }
        }

        object IAliRequest<OfferResponse>.GetReturnType()
        {
            return typeof(OfferDetailInfo);
        }
    }
}
