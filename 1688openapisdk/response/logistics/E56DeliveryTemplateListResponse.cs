using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.logistics;

namespace _1688openapisdk.response.logistics
{
    public class E56DeliveryTemplateListResponse:AliResponse
    {
        /// <summary>
        /// 调用结果：0:成功;2001:模板不存在;3001:参数错误;8001:业务异常;9001:超出流量控制;9999:系统异常
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// 模板描述详情
        /// </summary>
        public DeliveryTemplateBaseDescn[] result { get; set; }
    }
}
