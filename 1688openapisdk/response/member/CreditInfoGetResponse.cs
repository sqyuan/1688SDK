using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.member;

namespace _1688openapisdk.response.member
{
    public class CreditInfoGetResponse:AliResponse
    {
        public CreditInfo[] toReturn { get; set; }
    }
}
