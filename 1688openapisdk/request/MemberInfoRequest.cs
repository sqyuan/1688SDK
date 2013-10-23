using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;
using _1688openapisdk.domain;

namespace _1688openapisdk.request
{
    class MemberInfoRequest:IAliRequest<MemberInfoResponse>
    {

        public string memberId { get; set; }

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
