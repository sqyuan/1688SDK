using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.product;

namespace _1688openapisdk.response.product
{
    public class OfferCanModifyGetResponse:AliResponse
    {
        public OfferCanModifyResult[] toReturn { get; set; }
    }
}
