using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.product;
using _1688openapisdk.domain.product;
using _1688openapisdk.domain;

namespace _1688openapisdk.request.product
{
    /// <summary>
    /// 增量修改offer（该接口只支持价格和标题的增量修改！请慎用！）
    /// </summary>
    public class OfferModifyIncrementRequest : IAliRequest<OfferModifyIncrementResponse>
    {
        public OfferModifyIncrement offer { get; set; }

        public string access_token { get; set; }

        string IAliRequest<OfferModifyIncrementResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.modify.increment/";
        }

        IDictionary<string, string> IAliRequest<OfferModifyIncrementResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            Jayrock.Json.JsonTextWriter writer = new Jayrock.Json.JsonTextWriter();
            Jayrock.Json.Conversion.JsonConvert.Export(offer, writer);
            string str = writer.ToString();
            parameters.Add("offer", str);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<OfferModifyIncrementResponse>.Validate()
        {
            if (this.offer == null ||  this.access_token == null)
            {
                throw new AliException("offer,access_token   must not be null");
            }
        }

        object IAliRequest<OfferModifyIncrementResponse>.GetReturnType()
        {
            return typeof(OfferModifyIncrementResponse);
        }
    }
}
