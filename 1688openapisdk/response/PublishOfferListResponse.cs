using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain;

namespace _1688openapisdk.response
{
    public class PublishOfferListResponse:AliResponse
    {
        public OfferDetailInfo[] toReturn { get; set; }
    }
}
