using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.order
{
    public class OrderMemoModel
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public string gmtModified { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string gmtCreate { get; set; }
        /// <summary>
        /// 订单id
        /// </summary>
        public long orderId { get; set; }
        /// <summary>
        /// 会员id
        /// </summary>
        public string memberId { get; set; }
        /// <summary>
        /// 备注内容
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 备注图标
        /// </summary>
        public string remarkIcon { get; set; }
    }
}
