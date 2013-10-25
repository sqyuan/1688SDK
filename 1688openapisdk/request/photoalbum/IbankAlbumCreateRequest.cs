using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.request.photoalbum
{
    /// <summary>
    /// 本接口实现创建相册功能
    /// </summary>
    public class IbankAlbumCreateRequest : IAliRequest<IbankAlbumCreateResponse>
    {
        /// <summary>
        /// 相册名称。最长30个中文字符
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 相册描述。最长2000个中文字符
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 相册访问权限。取值范围:0-不公开；1-公开；2-密码访问。只有开通旺铺的会员可以设置相册访问权限为“1-公开”和“2-密码访问”，未开通旺铺的会员相册访问权限限制为“0-不公开”。
        /// </summary>
        public int authority { get; set; }

        /// <summary>
        /// 相册访问密码。4-16位非中文字符。当authority为2-密码访问时必填。
        /// </summary>
        public string password { get; set; }

        public string access_token { get; set; }

        string IAliRequest<IbankAlbumCreateResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/ibank.album.create/";
        }

        IDictionary<string, string> IAliRequest<IbankAlbumCreateResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("access_token", this.access_token);
            parameters.Add("name", this.name);
            parameters.Add("description", this.description);
            parameters.Add("authority", this.authority.ToString());
            parameters.Add("password", this.password);
            return parameters;
        }

        void IAliRequest<IbankAlbumCreateResponse>.Validate()
        {
            if (this.access_token == null || this.name == null)
            {
                throw new AliException("access_token and imageId must not be null");
            }
        }

        object IAliRequest<IbankAlbumCreateResponse>.GetReturnType()
        {
            return typeof(AlbumCreateResult);
        }
    }
}
