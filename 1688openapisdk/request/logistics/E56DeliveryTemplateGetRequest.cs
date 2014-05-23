using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.logistics;

namespace _1688openapisdk.domain.logistics
{
    /// <summary>
    /// 运费模板详情描述查询
    /// </summary>
    public class E56DeliveryTemplateGetRequest : IAliRequest<E56DeliveryTemplateGetResponse>
    {
         /// <summary>
        /// 调用者的中文站的memberId
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        public string templateId { get; set; }

        public string access_token { get; set; }

        string IAliRequest<E56DeliveryTemplateGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/e56.delivery.template.get/";
        }
        IDictionary<string, string> IAliRequest<E56DeliveryTemplateGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            parameters.Add("templateId", this.templateId);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<E56DeliveryTemplateGetResponse>.Validate()
        {
            if (this.memberId == null || this.templateId == null || this.access_token == null)
            {
                throw new AliException("memberId , templateId ,access_token   must not be null");
            }
        }

        object IAliRequest<E56DeliveryTemplateGetResponse>.GetReturnType()
        {
            return typeof(E56DeliveryTemplateGetResponse);
        }
    }
}
