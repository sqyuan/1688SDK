using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.domain.photoalbum
{
    /// <summary>
    /// 本接口实现获取当前用户相册内图片列表
    /// </summary>
    public class IbankImageListRequest : IAliRequest<IbankImageListResponse>
    {
        /// <summary>
        /// 相册ID
        /// </summary>
        public long albumId { get; set; }

        /// <summary>
        /// 返回列表结果集分页条数。取值范围:大于零的整数;最大值：500；默认值：10。
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数;默认值为1，即返回第一页数据。
        /// </summary>
        public int pageNo { get; set; }

        public string access_token { get; set; }

        string IAliRequest<IbankImageListResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/ibank.image.list/";
        }

        IDictionary<string, string> IAliRequest<IbankImageListResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("access_token", this.access_token);
            parameters.Add("albumId", this.albumId.ToString());
            parameters.Add("pageSize", this.pageSize.ToString());
            parameters.Add("pageNo", this.pageNo.ToString());
            return parameters;
        }

        void IAliRequest<IbankImageListResponse>.Validate()
        {
            if (this.access_token == null || this.albumId == 0)
            {
                throw new AliException("access_token and albumId must not be null");
            }
        }

        object IAliRequest<IbankImageListResponse>.GetReturnType()
        {
            return typeof(List<Image>);
        }
    }
}
