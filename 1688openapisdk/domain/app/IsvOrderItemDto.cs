using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.app
{
    /// <summary>
    /// ISV订单信息
    /// </summary>
    public class IsvOrderItemDto
    {
        /// <summary>
        /// 订单详细状态 audit_pass:审核通过，issue_ready：待发布，service：服务中，suspend：挂起 arrear_suspend：欠费挂起，closed：关闭，cancel：作废
        /// </summary>
        public string bizStatusExt { get;set;}

        /// <summary>
        /// 会员memberId
        /// </summary>
        public string memberId{get;set;}

        /// <summary>
        /// 产品名称
        /// </summary>
        public string productName{get;set;}

        /// <summary>
        /// 下单时间
        /// </summary>
        public string gmtCreate{get;set;}

        /// <summary>
        /// 到期时间
        /// </summary>
        public string gmtServiceEnd{get;set;}

        /// <summary>
        /// 订单状态 B:服务前，S:服务中，P：挂起，E：关闭，C:作废
        /// </summary>
        public string bizStatus{get;set;}

        /// <summary>
        /// 到帐金额
        /// </summary>
        public Double paymentAmount{get;set;}

        /// <summary>
        /// 执行金额
        /// </summary>
        public Double executePrice{get;set;}
    }
}
