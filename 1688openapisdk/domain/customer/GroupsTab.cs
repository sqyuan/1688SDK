using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.customer
{
    public class GroupsTab
    {
        /// <summary>
        /// 标签的id
        /// </summary>
        public int groupingId { get; set; }

        /// <summary>
        /// 标签状态	1表示正常,-1表示删除
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 该标签下客户的数量
        /// </summary>
        public int numOfMember { get; set; }

        public string sellerMemberId { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        public string groupingName { get; set; }

        /// <summary>
        /// 来自哪家子公司，0为淘宝，1为b2b
        /// </summary>
        public int fromSite { get; set; }
    }
}
