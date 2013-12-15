using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.logistics
{
    /// <summary>
    /// 运费模板费率描述
    /// </summary>
    public class DeliveryRateDescn
    {
        /// <summary>
        /// 到达区域描述信息 江苏省,杭州市,宁波市
        /// </summary>
        public string toAreaDescn { get; set; }

        /// <summary>
        /// 费率描述信息 首重1公斤5.00元;每增加1公斤,增加运费3.00元
        /// </summary>
        public string feeDescn { get; set; }

    }
}
