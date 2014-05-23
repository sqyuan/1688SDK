using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.product;
using _1688openapisdk.domain.product;

namespace _1688openapisdk.domain.product
{
    /// <summary>
    /// 通过本接口实现阿里巴巴中文站已登录卖家会员批量的设置指定offerID产品信息为过期商品的功能；转为过期的业务规则现有网站的业务逻辑保持一致；
    /// </summary>
    public class OfferExpireRequest : IAliRequest<OfferExpireResponse>
    {
        /// <summary>
        /// offer ID列表；目前只支持单个产品删除	1229546226
        /// </summary>
        public string offerIds { get; set; }
        public string access_token { get; set; }

        string IAliRequest<OfferExpireResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.expire/";
        }

        IDictionary<string, string> IAliRequest<OfferExpireResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerIds", this.offerIds);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<OfferExpireResponse>.Validate()
        {
            if (this.offerIds == null)
            {
                throw new AliException("offerIds must not be null");
            }
        }

        object IAliRequest<OfferExpireResponse>.GetReturnType()
        {
            return typeof(List<OfferExpireResult>);
        }
    }
}
