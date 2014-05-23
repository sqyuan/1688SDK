using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.userdefinecategory;

namespace _1688openapisdk.request.userdefinecategory
{
    /// <summary>
    /// 本接口实现通过数据接口的形式，批量获取指定产品所属的自定义分类ID
    /// </summary>
    public class UserCategoryGetOfferIdsRequest : IAliRequest<UserCategoryGetOfferIdsResponse>
    {
        public string access_token { get; set; }

        /// <summary>
        /// 需要查询的产品序列。多个产品id半角分号分隔	30904544;30904812;30904815
        /// </summary>
        public string offerIds { get; set; }


        string IAliRequest<UserCategoryGetOfferIdsResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/userCategory.get.offerIds/";
        }

        IDictionary<string, string> IAliRequest<UserCategoryGetOfferIdsResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerIds", this.offerIds);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<UserCategoryGetOfferIdsResponse>.Validate()
        {
            if (this.offerIds == null || this.access_token == null)
            {
                throw new AliException("offerIds,access_token must not be null");
            }
        }

        object IAliRequest<UserCategoryGetOfferIdsResponse>.GetReturnType()
        {
            return typeof(UserCategoryGetOfferIdsResponse);
        }
    }
}
