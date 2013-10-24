using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;
using _1688openapisdk.domain;

namespace _1688openapisdk.request
{
    /// <summary>
    /// 获取单个会员信息
    /// </summary>
    class MemberInfoRequest:IAliRequest<MemberInfoResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 自定义返回字段。在memberInfo结构中选择需要返回的字段名称，半角逗号分隔companyName,sellerName,department
        /// </summary>
        public string[] returnFields { get; set; }

        public string access_token { get;set;}

        string IAliRequest<MemberInfoResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/member.get/";
        }

        IDictionary<string, string> IAliRequest<MemberInfoResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            if (this.returnFields != null)
            {
                parameters.Add("returnFields", String.Join(",", this.returnFields));
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<MemberInfoResponse>.Validate()
        {
            if (this.memberId == null)
            {
                throw new AliException("memberId must not be null");
            }
        }
        public object GetReturnType()
        {
            return typeof(MemberInfo);
        }
    }
}
