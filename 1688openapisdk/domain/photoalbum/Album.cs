using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.photoalbum
{
    /// <summary>
    /// 相册信息
    /// </summary>
    public class Album
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        /// 相册ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 相册类型.CUSTOM-自定义相册 MY-我的相册 OFF-下架相册
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 相册名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 相册描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 相册创建时间,格式为“yyyy-MM-dd”
        /// </summary>
        public string createDate { get; set; }

        /// <summary>
        /// 相册中图片数量
        /// </summary>
        public int imageCount{get;set;}

        /// <summary>
        /// 相册封面图片URL
        /// </summary>
        public string coverPicUrl { get; set; }

        /// <summary>
        /// 相册封面图片ID
        /// </summary>
        public int coverPicId { get; set; }

    }
}
