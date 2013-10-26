using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.customer
{
    public class Relation
    {
        public string phone { get; set; }

        /// <summary>
        /// 1表示交易成功，2表示交易关闭 3表示手动新增
        /// </summary>
        public int relationSource { get; set; }

        public string buyerMemberId { get; set; }

        public string sellerMemberId { get; set; }

        /// <summary>
        /// 1表示普通会员，2表示高级会员，3表示vip会员，4表示至尊会员，默认0，其他
        /// </summary>
        public int grade { get; set; }
    }
}
