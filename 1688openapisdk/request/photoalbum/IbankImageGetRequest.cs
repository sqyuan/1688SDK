using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.request.photoalbum
{
    /// <summary>
    /// 本接口实现获取当前用户的图片信息
    /// </summary>
    public class IbankImageGetRequest : IAliRequest<IbankImageGetResponse>
    {
        public long imageId { get; set; }

        public string access_token { get; set; }

        string IAliRequest<IbankImageGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/ibank.image.get/";
        }

        IDictionary<string, string> IAliRequest<IbankImageGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("access_token", this.access_token);
            parameters.Add("imageId", this.imageId.ToString());
            return parameters;
        }

        void IAliRequest<IbankImageGetResponse>.Validate()
        {
            if (this.access_token == null || this.imageId == 0)
            {
                throw new AliException("access_token and imageId must not be null");
            }
        }

        object IAliRequest<IbankImageGetResponse>.GetReturnType()
        {
            return typeof(Image);
        }
    }
}
