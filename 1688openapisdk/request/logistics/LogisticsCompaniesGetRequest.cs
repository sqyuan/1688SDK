using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;
using _1688openapisdk.domain;

namespace _1688openapisdk.request
{
    /// <summary>
    /// 获取物流公司列表
    /// </summary>
    public class LogisticsCompaniesGetRequest : IAliRequest<LogisticsCompaniesGetResponse>
    {
        /// <summary>
        /// 调用者的中文站的memberId
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 通过服务类型来获取支持该服务的物流公司列表，目前只支持自行发货（ZX）
        /// </summary>
        public string serviceType { get; set; }

        public string access_token { get; set; }

        string IAliRequest<LogisticsCompaniesGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/e56.logistics.companies.get/";
        }

        IDictionary<string, string> IAliRequest<LogisticsCompaniesGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            parameters.Add("serviceType", this.serviceType);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<LogisticsCompaniesGetResponse>.Validate()
        {
            if (this.memberId == null || this.serviceType == null || this.access_token == null)
            {
                throw new AliException("memberId , serviceType ,access_token   must not be null");
            }
        }

        object IAliRequest<LogisticsCompaniesGetResponse>.GetReturnType()
        {
            return typeof(LogisticsCompaniesGetResponse);
        }
    }
}
