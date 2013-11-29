using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.orderpush.domain
{
    /// <summary>
    /// 产品图片/快照图片
    /// </summary>
    public class OfferSnapshotImageUrl
    {
        /// <summary>
        /// 大图图片：全路径
        /// </summary>
        public string imgUrl{get;set;}
        /// <summary>
        /// 小图图片：全路径，目前动态生成小图规格：64x64
        /// </summary>
        public string midImgUrl{get;set;}
        /// <summary>
        /// 中图图片：全路径，目前动态生成中图规格：150x150
        /// </summary>
        public string summImgUrl { get; set; }

    }
}
