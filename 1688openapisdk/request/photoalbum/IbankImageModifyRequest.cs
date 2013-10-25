using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.request.photoalbum
{
    /// <summary>
    /// 本接口实现修改图片信息功能
    /// </summary>
    public class IbankImageModifyRequest : IAliRequest<IbankImageModifyResponse>
    {
        /// <summary>
        /// 	图片ID
        /// </summary>
        public long imageId { get; set; }
        /// <summary>
        /// 图片名称。最长30个中文字符
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 图片描述。最长2000个中文字符
        /// </summary>
        public string description { get; set; }

        public string access_token { get; set; }

        string IAliRequest<IbankImageModifyResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/ibank.image.modify/";
        }

        IDictionary<string, string> IAliRequest<IbankImageModifyResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("imageId", this.imageId.ToString());
            parameters.Add("access_token", this.access_token);
            parameters.Add("name", this.name);
            parameters.Add("description", this.description);
            return parameters;
        }

        void IAliRequest<IbankImageModifyResponse>.Validate()
        {
            if (this.access_token == null || this.imageId == 0)
            {
                throw new AliException("access_token and imageId must not be null");
            }
        }

        object IAliRequest<IbankImageModifyResponse>.GetReturnType()
        {
            return typeof(ModifyResult);
        }
    }
}
