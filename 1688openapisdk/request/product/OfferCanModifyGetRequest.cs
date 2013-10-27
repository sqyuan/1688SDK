using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.product;
using _1688openapisdk.domain.product;

namespace _1688openapisdk.request.product
{
    /// <summary>
    /// 通过本接口实现阿里巴巴中文站已登录会员获取指定产品是否可以修改的信息
    /// </summary>
    public class OfferCanModifyGetRequest : IAliRequest<OfferCanModifyGetResponse>
    {
        /// <summary>
        /// 查询的产品序列。多个产品id半角分号分隔	808930048;799629527
        /// </summary>
        public string offerIds { get; set; }

        public string access_token { get; set; }

        string IAliRequest<OfferCanModifyGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.canModify.get/";
        }

        IDictionary<string, string> IAliRequest<OfferCanModifyGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerIds", this.offerIds);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<OfferCanModifyGetResponse>.Validate()
        {
            if (this.offerIds == null)
            {
                throw new AliException("offerIds must not be null");
            }
        }

        object IAliRequest<OfferCanModifyGetResponse>.GetReturnType()
        {
            return typeof(List<OfferCanModifyResult>);
        }
    }
}
