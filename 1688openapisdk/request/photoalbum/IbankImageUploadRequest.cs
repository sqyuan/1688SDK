using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.photoalbum;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.request.photoalbum
{
    /// <summary>
    /// 本接口实现图片上传接口，将图片上传到指定相册
    /// </summary>
    public class IbankImageUploadRequest : IAliRequest<IbankImageUploadResponse>
    {
        /// <summary>
        /// 相册ID
        /// </summary>
        public long albumId { get; set; }
        /// <summary>
        /// 图片名称。最长30个中文字符
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 图片描述。最长2000个中文字符
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 是否打上默认水印
        /// </summary>
        public Boolean drawTxt { get; set; }

        /// <summary>
        /// 图片的二进制数据，向服务端提交文件即可
        /// </summary>
        public byte[] imageBytes { get; set; }

        public string access_token { get; set; }

        string IAliRequest<IbankImageUploadResponse>.GetApiName()
        {
            throw new NotImplementedException();
        }

        IDictionary<string, string> IAliRequest<IbankImageUploadResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("access_token", this.access_token);
            parameters.Add("name", this.name);
            parameters.Add("description", this.description);
            parameters.Add("albumId", this.albumId.ToString());
            parameters.Add("drawTxt", this.drawTxt.ToString());
            parameters.Add("imageBytes", this.imageBytes.ToString());
            return parameters;
        }

        void IAliRequest<IbankImageUploadResponse>.Validate()
        {
            if (this.access_token == null || this.albumId == 0 || this.name == null)
            {
                throw new AliException("access_token , albumId and name must not be null");
            }
        }

        object IAliRequest<IbankImageUploadResponse>.GetReturnType()
        {
            return typeof(Image);
        }
    }
}
