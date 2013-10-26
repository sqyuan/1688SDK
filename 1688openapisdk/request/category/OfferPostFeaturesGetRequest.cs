using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.category;
using _1688openapisdk.domain.category;

namespace _1688openapisdk.request.category
{
    /// <summary>
    /// 根据叶子类目ID获取类目发布属性信息
    /// </summary>
    public class OfferPostFeaturesGetRequest : IAliRequest<OfferPostFeaturesGetResponse>
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        public long categoryID { get; set; }

        string IAliRequest<OfferPostFeaturesGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offerPostFeatures.get/";
        }

        IDictionary<string, string> IAliRequest<OfferPostFeaturesGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("categoryID", this.categoryID.ToString());
            return parameters;
        }

        void IAliRequest<OfferPostFeaturesGetResponse>.Validate()
        {
            if (this.categoryID == 0)
            {
                throw new AliException("categoryID must not be null");
            }
        }

        object IAliRequest<OfferPostFeaturesGetResponse>.GetReturnType()
        {
            return typeof(List<PostAtrribute>);
        }
    }
}
