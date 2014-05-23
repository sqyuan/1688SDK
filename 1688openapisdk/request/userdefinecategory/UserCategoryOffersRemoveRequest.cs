using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.userdefinecategory;

namespace _1688openapisdk.request.userdefinecategory
{
    /// <summary>
    /// 本接口实现通过数据接口的形式，批量移除多个产品的一个自定义分类 userCategory.offers.remove -- version: 1
    /// </summary>
    public class UserCategoryOffersRemoveRequest : IAliRequest<UserCategoryOffersRemoveResponse>
    {
        public string access_token { get; set; }

        /// <summary>
        /// 需要删除的产品序列。多个产品id半角分号分隔	30904544;30904812;30904815
        /// </summary>
        public string offerIds { get; set; }

        /// <summary>
        /// 要删除的自定义分类ID	4737
        /// </summary>
        public long groupId { get; set; }

        string IAliRequest<UserCategoryOffersRemoveResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/userCategory.offers.remove/";
        }

        IDictionary<string, string> IAliRequest<UserCategoryOffersRemoveResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerIds", this.offerIds);
            parameters.Add("access_token", this.access_token);
            parameters.Add("groupId", this.groupId.ToString());
            return parameters;
        }

        void IAliRequest<UserCategoryOffersRemoveResponse>.Validate()
        {
            if (this.offerIds == null || this.groupId == null || this.access_token == null)
            {
                throw new AliException("offerIds,groupId,access_token must not be null");
            }
        }

        object IAliRequest<UserCategoryOffersRemoveResponse>.GetReturnType()
        {
            return typeof(UserCategoryOffersRemoveResponse);
        }
    }
}
