using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.product;

namespace _1688openapisdk.response.product
{
    public class OfferDeleteResponse:AliResponse
    {
        public OfferDeteleResult[] toReturn { get; set; }
    }
}
