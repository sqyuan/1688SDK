using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.category;

namespace _1688openapisdk.response.category
{
    public class CategoryGetCatePathResponse:AliResponse
    {
        public OfferCatsInfo[] toReturn { get; set; }
    }
}
