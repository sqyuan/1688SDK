using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.product;
using _1688openapisdk.domain.product;

namespace _1688openapisdk.request.product
{
    /// <summary>
    /// 本接通过数据接口的形式，实现阿里巴巴中文站登录会员修改offer的功能。 注意：该接口是全量修改，不传的值会被清空。每条offer每天最多被改30次。
    /// </summary>
    public class OfferModifyRequest : IAliRequest<OfferModifyResponse>
    {
        public Offer offer { get; set; }

        public string access_token { get; set; }

        string IAliRequest<OfferModifyResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.modify/";
        }

        IDictionary<string, string> IAliRequest<OfferModifyResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            Jayrock.Json.JsonTextWriter writer = new Jayrock.Json.JsonTextWriter();
            Jayrock.Json.Conversion.JsonConvert.Export(offer, writer);
            string str = writer.ToString();
            parameters.Add("offer", str);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<OfferModifyResponse>.Validate()
        {
            if (this.offer == null || this.access_token == null)
            {
                throw new AliException("offer,access_token   must not be null");
            }
        }

        object IAliRequest<OfferModifyResponse>.GetReturnType()
        {
            return typeof(OfferModifyResponse);
        }
    }
}
