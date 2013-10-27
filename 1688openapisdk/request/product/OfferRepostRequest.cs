using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.product;
using _1688openapisdk.domain.product;

namespace _1688openapisdk.request.product
{
    /// <summary>
    /// 通过本接口实现阿里巴巴中文站已登录卖家会员批量重发指定offerID产品信息上网的功能； 重发规则与网站一致：1、每条供应产品24小时以内，只能重发一次；2、每个客户每天重发产品上限为400条。
    /// </summary>
    public class OfferRepostRequest : IAliRequest<OfferRepostResponse>
    {
        /// <summary>
        /// offer ID列表；目前只支持单个产品删除	1229546226
        /// </summary>
        public string offerIds { get; set; }
        public string access_token { get; set; }

        string IAliRequest<OfferRepostResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.expire/";
        }

        IDictionary<string, string> IAliRequest<OfferRepostResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerIds", this.offerIds);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<OfferRepostResponse>.Validate()
        {
            if (this.offerIds == null)
            {
                throw new AliException("offerIds must not be null");
            }
        }

        object IAliRequest<OfferExpireResponse>.GetReturnType()
        {
            return typeof(List<OfferRepostResult>);
        }
    }
}
