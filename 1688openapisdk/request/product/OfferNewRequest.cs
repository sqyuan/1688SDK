using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.product;
using _1688openapisdk.domain.product;

namespace _1688openapisdk.request.product
{
    /// <summary>
    /// 本接口通过数据接口的形式，实现阿里巴巴中文站登录会员发布offer的功能。每个客户每天最多新发布1000个产品。
    /// </summary>
    public class OfferNewRequest : IAliRequest<OfferNewResponse>
    {
        public Offer offer { get; set; }

        public string access_token { get; set; }

        string IAliRequest<OfferNewResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.new/";
        }

        IDictionary<string, string> IAliRequest<OfferNewResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            Jayrock.Json.JsonTextWriter writer = new Jayrock.Json.JsonTextWriter();
            Jayrock.Json.Conversion.JsonConvert.Export(offer, writer);
            string str = writer.ToString();
            parameters.Add("offer", str);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<OfferNewResponse>.Validate()
        {
            if (this.offer == null || this.access_token == null)
            {
                throw new AliException("offer,access_token   must not be null");
            }
        }

        object IAliRequest<OfferNewResponse>.GetReturnType()
        {
            return typeof(OfferNewResponse);
        }
    }
}
