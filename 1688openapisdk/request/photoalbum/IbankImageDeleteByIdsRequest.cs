using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.domain.photoalbum
{
    /// <summary>
    /// 本接口实现批量删除图片功能
    /// </summary>
    public class IbankImageDeleteByIdsRequest : IAliRequest<IbankImageDeleteByIdsResponse>
    {
        /// <summary>
        /// 图片ID序列，以半角分号”;”分隔。每次最多支持删除500张图片。
        /// </summary>
        public string imageIds { get; set; }

        public string access_token { get; set; }

        string IAliRequest<IbankImageDeleteByIdsResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/ibank.image.deleteByIds/";
        }

        IDictionary<string, string> IAliRequest<IbankImageDeleteByIdsResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("access_token", this.access_token);
            parameters.Add("imageIds", this.imageIds);
            return parameters;
        }

        void IAliRequest<IbankImageDeleteByIdsResponse>.Validate()
        {
            if (this.access_token == null || this.imageIds == null)
            {
                throw new AliException("access_token and imageIds must not be null");
            }
        }

        object IAliRequest<IbankImageDeleteByIdsResponse>.GetReturnType()
        {
            return typeof(List<AlbumDeleteResult>);
        }
    }
}
