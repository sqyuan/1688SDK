using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.member
{
    public class CreditInfo
    {
        /// <summary>
        /// 诚信通logo的URL。1、logo中包括诚信通类型、企业Or个人(ETP:企业,PTP：个人,MTP：专业市，NONE_TP:非诚信通)Logo类型根据输入参数中的类型决定；2、如果logo类型输入值为空，提供默认logo
        /// </summary>
        public string tpLogo { get; set; }

        public string tpYear { get; set; }

        public string tpType { get; set; }

        public string creditBalanceMoney { get; set; }

        public string memberId { get; set; }

        public string[] creditVas { get; set; }
    }
}
