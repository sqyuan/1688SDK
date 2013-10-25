using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.order;
using _1688openapisdk.domain.order;

namespace _1688openapisdk.request.order
{
    /// <summary>
    /// 本接口实现获取指定会员在阿里巴巴中文站上的发货地址列表信息
    /// </summary>
    public class TradeFreightSendGoodsAddressListGetRequest : IAliRequest<TradeFreightSendGoodsAddressListGetResponse>
    {
        /// <summary>
        /// 自定义返回字段，字段为deliveryAddressId,updateTime,isCommonUse,contactName,location,address,postcode,telephone,mobilephone（目前不支持选择部分字段，必须输入全部字段）。多个字段以半角','分隔。若此字段为空，则返回数组信息为空
        /// </summary>
        public string returnFields { get; set; }

        /// <summary>
        /// 会员ID
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 是否只取常用发货地址
        /// </summary>
        public Boolean commonUseOnly { get; set; }

        public string access_token { get; set; }

        string IAliRequest<TradeFreightSendGoodsAddressListGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/trade.freight.sendGoodsAddressList.get/";
        }

        IDictionary<string, string> IAliRequest<TradeFreightSendGoodsAddressListGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (this.returnFields != null)
            {
                parameters.Add("returnFields", this.returnFields);
            }
            if (this.memberId != null)
            {
                parameters.Add("memberId", this.memberId);
            }
            if (this.commonUseOnly != null)
            {
                parameters.Add("commonUseOnly", this.commonUseOnly.ToString());
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<TradeFreightSendGoodsAddressListGetResponse>.Validate()
        {
            if (this.access_token == null)
            {
                throw new AliException("access_token must not be null");
            }
        }

        object IAliRequest<TradeFreightSendGoodsAddressListGetResponse>.GetReturnType()
        {
            return typeof(List<DeliveryAddress>);
        }
    }
}
