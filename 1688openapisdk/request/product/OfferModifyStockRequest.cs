using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.product;

namespace _1688openapisdk.domain.product
{
    /// <summary>
    /// 增量修改产品库存
    /// </summary>
    public class OfferModifyStockRequest : IAliRequest<OfferModifyStockResponse>
    {
        /// <summary>
        /// 产品编号
        /// </summary>
        public long offerId { get; set; }

        /// <summary>
        /// 总库存改变量
        /// </summary>
        public int offerAmountChange { get; set; }

        /// <summary>
        /// Sku报价产品，指定规格的库存变量，注是所有规格改变量之和要等于offerAmountChange 数据格式{"specId":"number"},key是sku信息中的specId，后者为库存变更量
        /// </summary>
        public Dictionary<string, string> skuAmountChange { get; set; }

        public string access_token { get; set; }

        string IAliRequest<OfferModifyStockResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.modify.stock/";
        }

        IDictionary<string, string> IAliRequest<OfferModifyStockResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("offerId", this.offerId.ToString());
            parameters.Add("offerAmountChange", this.offerAmountChange.ToString());
            if (this.skuAmountChange != null)
            {
                Jayrock.Json.JsonTextWriter writer = new Jayrock.Json.JsonTextWriter();
                Jayrock.Json.Conversion.JsonConvert.Export(this.skuAmountChange, writer);
                string str = writer.ToString();
                parameters.Add("skuAmountChange", str);
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<OfferModifyStockResponse>.Validate()
        {
            if (this.offerId == null || this.access_token == null)
            {
                throw new AliException("offerId ,access_token   must not be null");
            }
        }

        object IAliRequest<OfferModifyStockResponse>.GetReturnType()
        {
            return typeof(OfferModifyStockResponse);
        }
    }
}
