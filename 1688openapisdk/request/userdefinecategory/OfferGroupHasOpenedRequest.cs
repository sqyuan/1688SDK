using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.userdefinecategory;

namespace _1688openapisdk.request.userdefinecategory
{
    /// <summary>
    /// 获取阿里巴巴中国网站会员是否已经开启自定义分类功能
    /// </summary>
    public class OfferGroupHasOpenedRequest : IAliRequest<OfferGroupHasOpenedResponse>
    {
        public string memberId { get; set; }

        string IAliRequest<OfferGroupHasOpenedResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offerGroup.hasOpened/";
        }

        IDictionary<string, string> IAliRequest<OfferGroupHasOpenedResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            return parameters;
        }

        void IAliRequest<OfferGroupHasOpenedResponse>.Validate()
        {
            if (this.memberId == null)
            {
                throw new AliException("memberId must not be null");
            }
        }

        object IAliRequest<OfferGroupHasOpenedResponse>.GetReturnType()
        {
            return typeof(OfferGroupHasOpenedResponse);
        }
    }
}
