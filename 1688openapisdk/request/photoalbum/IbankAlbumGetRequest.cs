using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.domain.photoalbum
{
    /// <summary>
    /// 本接口实现根据相册id获取相册信息
    /// </summary>
    public class IbankAlbumGetRequest : IAliRequest<IbankAlbumGetResponse>
    {
        /// <summary>
        /// 相册ID
        /// </summary>
        public long albumId { get; set; }

        public string access_token { get; set; }

        string IAliRequest<IbankAlbumGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/ibank.album.get/";
        }

        IDictionary<string, string> IAliRequest<IbankAlbumGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("access_token", this.access_token);
            parameters.Add("albumId", this.albumId.ToString());
            return parameters;
        }

        void IAliRequest<IbankAlbumGetResponse>.Validate()
        {
            if (this.access_token == null || this.albumId == 0)
            {
                throw new AliException("access_token and albumId must not be null");
            }
        }

        object IAliRequest<IbankAlbumGetResponse>.GetReturnType()
        {
            return typeof(Album);
        }
    }
}
