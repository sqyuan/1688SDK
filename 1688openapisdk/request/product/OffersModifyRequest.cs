using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.product;

namespace _1688openapisdk.domain.product
{
    /// <summary>
    /// 批量修改offer价格 供货量 标题
    /// </summary>
    public class OffersModifyRequest : IAliRequest<OffersModifyResponse>
    {
        /// <summary>
        /// 产品id
        /// </summary>
        public string[] offerIds;

        public string[] subjects;

        public string[] priceRanges;

        public string[] amounts;

        public Boolean isModify;

        public string access_token { get; set; }

        string IAliRequest<OffersModifyResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offers.modify/";
        }

        IDictionary<string, string> IAliRequest<OffersModifyResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerIds", String.Join(",",this.offerIds));
            if (this.subjects != null)
            {
                parameters.Add("subjects", String.Join(",", this.subjects));
            }
            if (this.amounts != null)
            {
                parameters.Add("amounts", String.Join(",", this.amounts));
            }
            if (this.priceRanges != null)
            {
                parameters.Add("priceRanges", String.Join(",", this.priceRanges));
            }
            if (this.isModify != null)
            {
                parameters.Add("isModify", this.isModify.ToString());
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<OffersModifyResponse>.Validate()
        {
            if (this.offerIds == null ||this.access_token == null)
            {
                throw new AliException("offerIds , returnFields ,access_token   must not be null");
            }
        }

        object IAliRequest<OffersModifyResponse>.GetReturnType()
        {
            return typeof(OffersModifyResponse);
        }
    }
}
