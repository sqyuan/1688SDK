using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;

namespace _1688openapisdk.request
{
    public class AllOfferListRequest : PublishOfferListRequest, IAliRequest<PublishOfferListResponse>
    {
        string IAliRequest<PublishOfferListResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.getAllOfferList/";
        }
    }
}
