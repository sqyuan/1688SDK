using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    /// 父类目信息
    /// </summary>
    public class ParentCatInfo
    {
        /// <summary>
        /// 父类目ID
        /// </summary>
        public int parentCatsId { get; set; }

        /// <summary>
        /// 类目排序
        /// </summary>
        public int order { get; set; }
    }
}
