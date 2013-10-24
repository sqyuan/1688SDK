using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;

namespace _1688openapisdk.request
{
    /// <summary>
    /// 获取当前会话会员的所有产品列表
    /// </summary>
    public class AllOfferListRequest : PublishOfferListRequest, IAliRequest<PublishOfferListResponse>
    {
        string IAliRequest<PublishOfferListResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.getAllOfferList/";
        }
    }
}
