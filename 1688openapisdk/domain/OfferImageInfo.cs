using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class OfferImageInfo
    {
        /// <summary>
        /// 310*310图片路径
        /// </summary>
        public string size310x310URL { get; set; }

        /// <summary>
        /// 100*100图片路径
        /// </summary>
        public string summURL { get; set; }

        /// <summary>
        /// 64*64图片路径
        /// </summary>
        public string size64x64URL { get; set; }

        /// <summary>
        /// 256*256图片路径
        /// </summary>
        public string imageURI { get; set; }

        /// <summary>
        /// 原始图片路径
        /// </summary>
        public string originalImageURI { get; set; }
    }
}
