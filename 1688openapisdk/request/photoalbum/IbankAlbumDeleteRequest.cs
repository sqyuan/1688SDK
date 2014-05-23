using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.domain.photoalbum
{
    /// <summary>
    /// 本接口实现批量删除相册功能
    /// </summary>
    public class IbankAlbumDeleteRequest : IAliRequest<IbankAlbumDeleteResponse>
    {
        /// <summary>
        /// 相册ID序列，以半角分号”;”分隔。每次最多支持删除500个相册。
        /// </summary>
        public string albumIds { get; set; }

        public string access_token { get; set; }


        string IAliRequest<IbankAlbumDeleteResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/ibank.album.delete/";
        }

        IDictionary<string, string> IAliRequest<IbankAlbumDeleteResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("access_token", this.access_token);
            parameters.Add("albumIds", this.albumIds);
            return parameters;
        }

        void IAliRequest<IbankAlbumDeleteResponse>.Validate()
        {
            if (this.access_token == null || this.albumIds == null)
            {
                throw new AliException("access_token and albumIds must not be null");
            }
        }

        object IAliRequest<IbankAlbumDeleteResponse>.GetReturnType()
        {
            return typeof(List<AlbumDeleteResult>);
        }
    }
}
