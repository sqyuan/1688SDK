using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.logistics;

namespace _1688openapisdk.domain.logistics
{
    /// <summary>
    /// 用户运费模板列表描述查询
    /// </summary>
    public class E56DeliveryTemplateListRequest : IAliRequest<E56DeliveryTemplateListResponse>
    {
        /// <summary>
        /// 调用者的中文站的memberId
        /// </summary>
        public string memberId { get; set; }

        public string access_token { get; set; }

        string IAliRequest<E56DeliveryTemplateListResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/e56.delivery.template.list/";
        }

        IDictionary<string, string> IAliRequest<E56DeliveryTemplateListResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<E56DeliveryTemplateListResponse>.Validate()
        {
            if (this.memberId == null || this.access_token == null)
            {
                throw new AliException("memberId  ,access_token   must not be null");
            }
        }

        object IAliRequest<E56DeliveryTemplateListResponse>.GetReturnType()
        {
            return typeof(E56DeliveryTemplateListResponse);
        }
    }
}
