using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.userdefinecategory
{
    /// <summary>
    /// 会员自定义分类信息
    /// </summary>
    public class SellerCatInfo
    {
        /// <summary>
        /// 自定义分类ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int ordering { get; set; }

        /// <summary>
        /// 分类图片URL
        /// </summary>
        public string iconUrl { get; set; }

        /// <summary>
        /// 父分类id
        /// </summary>
        public int pid { get; set; }
        /// <summary>
        /// 子分类
        /// </summary>
        public SellerCatInfo[] children { get; set; }
    }
}
