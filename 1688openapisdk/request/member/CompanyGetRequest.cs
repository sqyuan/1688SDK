using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.member;
using _1688openapisdk.domain.member;

namespace _1688openapisdk.request.member
{
    /// <summary>
    /// 获取阿里巴巴中国网站会员的公司库信息
    /// </summary>
    public class CompanyGetRequest : IAliRequest<CompanyGetResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 自定义返回字段。在companInfo结构中选择需要返回的字段名称，半角逗号分隔 companyName,productionService,companyCategoryInfo,foundedPlace
        /// </summary>
        public string returnFields { get; set; }

        public string access_token { get; set; }

        string IAliRequest<CompanyGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/company.get/";
        }

        IDictionary<string, string> IAliRequest<CompanyGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            if (this.returnFields != null)
            {
                parameters.Add("returnFields", returnFields);
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<CompanyGetResponse>.Validate()
        {
            if (this.memberId == null)
            {
                throw new AliException("memberId must not be null");
            }
        }

        object IAliRequest<CompanyGetResponse>.GetReturnType()
        {
            return typeof(List<CompanyInfo>);
        }
    }
}
