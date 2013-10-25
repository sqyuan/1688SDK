using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.photoalbum
{
    public class Image
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        /// 图片ID
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 图片描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 图片URL(原图)，图片的相对路径（即除去http://server:port部分，如:img/ibank/15/02/60/15026073.jpg）
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 图片URL(缩略图)，图片的相对路径（即除去http://server:port部分，如:img/ibank/15/02/60/15026073.jpg）
        /// </summary>
        public string urlMini { get; set; }

        /// <summary>
        /// 图片URL(310x310)，图片的相对路径（即除去http://server:port部分，如:img/ibank/15/02/60/15026073.jpg）
        /// </summary>
        public string url310x310 { get; set; }

        /// <summary>
        /// 图片URL(220x220)，图片的相对路径（即除去http://server:port部分，如:img/ibank/15/02/60/15026073.jpg）
        /// </summary>
        public string url220x220 { get; set; }

        /// <summary>
        /// 图片URL(64x64)，图片的相对路径（即除去http://server:port部分，如:img/ibank/15/02/60/15026073.jpg）
        /// </summary>
        public string url64x64 { get; set; }

        /// <summary>
        /// 图片上传时间
        /// </summary>
        public string createTime { get; set; }

        /// <summary>
        /// 图片大小，单位为字节
        /// </summary>
        public int size { get; set; }

        /// <summary>
        /// 图片所属相册
        /// </summary>
        public int albumId { get; set; }

    }
}
