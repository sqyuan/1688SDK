using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.domain.photoalbum
{
    /// <summary>
    /// 本接口实现获取当前用户信息，包括可用空间和总空间等
    /// </summary>
    public class IbankProfileGetRequest : IAliRequest<IbankProfileGetResponse>
    {
        public string unused { get; set; }

        public string access_token { get; set; }

        string IAliRequest<IbankProfileGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/ibank.profile.get/";
        }

        IDictionary<string, string> IAliRequest<IbankProfileGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("access_token", this.access_token);
            if (this.unused != null)
            {
                parameters.Add("unused", this.unused);
            }
            return parameters;
        }

        void IAliRequest<IbankProfileGetResponse>.Validate()
        {
            if (this.access_token == null)
            {
                throw new AliException("access_token must not be null");
            }
        }

        object IAliRequest<IbankProfileGetResponse>.GetReturnType()
        {
            return typeof(Profile);
        }
    }
}
