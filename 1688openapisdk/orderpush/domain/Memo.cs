using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.orderpush.domain
{
    /// <summary>
    /// 备忘
    /// </summary>
    public class Memo
    {
        /// <summary>
        /// 所属会员
        /// </summary>
        public string memberId{get;set;}
        /// <summary>
        /// 备注内容
        /// </summary>
        public string remark{get;set;}
        /// <summary>
        /// 备注标识，目前有4种，展示使用
        /// </summary>
        public string remarkIcon { get; set; }

    }
}
