using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.request.photoalbum
{
    /// <summary>
    /// 本接口实现获取当前用户相册列表
    /// </summary>
    public class IbankAlbumListRequest : IAliRequest<IbankAlbumListResponse>
    {
        /// <summary>
        /// 相册类型
        /// </summary>
        public string albumType { get; set; }

        /// <summary>
        /// 返回列表结果集分页条数。取值范围:大于零的整数;最大值：500；默认值：10。
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数;默认值为1，即返回第一页数据。
        /// </summary>
        public int pageNo { get; set; }

        public string access_token { get; set; }

        string IAliRequest<IbankAlbumListResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/ibank.album.list/";
        }

        IDictionary<string, string> IAliRequest<IbankAlbumListResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("access_token", this.access_token);
            parameters.Add("albumType", this.albumType);
            parameters.Add("pageSize", this.pageSize.ToString());
            parameters.Add("pageNo", this.pageNo.ToString());
            return parameters;
        }

        void IAliRequest<IbankAlbumListResponse>.Validate()
        {
            if (this.access_token == null || this.albumType == null)
            {
                throw new AliException("access_token and albumType must not be null");
            }
        }

        object IAliRequest<IbankAlbumListResponse>.GetReturnType()
        {
            return typeof(List<Album>);
        }
    }
}
