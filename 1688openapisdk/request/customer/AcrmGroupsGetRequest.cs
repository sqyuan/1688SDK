using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.customer;
using _1688openapisdk.domain.customer;

namespace _1688openapisdk.domain.customer
{
    /// <summary>
    /// 查询某个memberId下面所有的分组标签
    /// </summary>
    public class AcrmGroupsGetRequest : IAliRequest<AcrmGroupsGetResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string memberId { get; set; }

        public string access_token { get; set; }


        string IAliRequest<AcrmGroupsGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/acrm.groups.get/";
        }

        IDictionary<string, string> IAliRequest<AcrmGroupsGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<AcrmGroupsGetResponse>.Validate()
        {
            if (this.memberId == null)
            {
                throw new AliException("memberId must not be null");
            }
        }

        object IAliRequest<AcrmGroupsGetResponse>.GetReturnType()
        {
            return typeof(List<GroupsTab>);
        }
    }
}
