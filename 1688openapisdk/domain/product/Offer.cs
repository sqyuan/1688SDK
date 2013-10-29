using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.product
{
    /// <summary>
    /// 产品入参信息,新发修改时的产品入参结构
    /// </summary>
    public class Offer
    {

        /// <summary>
        /// 贸易类型。1：产品，2：加工，3：代理，4：合作，5：商务服务 不传入默认按照产品发布
        /// </summary>
        public int bizType { get; set; }


        /// <summary>
        /// 是否图片私密信息
        /// </summary>
        public Boolean pictureAuthOffer { get; set; }

        /// <summary>
        /// 是否价格私密
        /// </summary>
        public Boolean priceAuthOffer { get; set; }

        /// <summary>
        /// 是否支持按照规格报价
        /// </summary>
        public Boolean skuTradeSupport { get; set; }

        /// <summary>
        /// 是否支持混批
        /// </summary>
        public Boolean mixWholeSale { get; set; }

        /// <summary>
        /// 是否为私密offer的标志位。true：私密产品 false：普通产品
        /// </summary>
        public bool isPrivate { get; set; }

        /// <summary>
        /// 信息ID。修改的时候需要传入，新发情况下不要填入
        /// </summary>
        public long offerId { get; set; }

        /// <summary>
        /// 区间价格。每个区间之间用`分割，冒号前面是起订量，后面是价格	20:10`30:9`40:8
        /// </summary>
        public string priceRanges { get; set; }

        /// <summary>
        /// 可售数量
        /// </summary>
        public int amountOnSale { get; set; }

        /// <summary>
        /// 产品属性列表。key是属性id， value是值。所有的属性值都需要传入，包括产品属性和除价格之外的交易属性	{\"1459\":\"吨\"}
        /// </summary>
        public string productFeatures { get; set; }

        /// <summary>
        /// 自定义类目信息。如果有父ID ，则格式为：父id:子ID	userCategorys:[\"19347\",\"19349:21410\"]
        /// </summary>
        public string[] userCategorys { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        public int categoryID { get; set; }

        /// <summary>
        /// 信息有效期
        /// </summary>
        public int periodOfValidity { get; set; }

        /// <summary>
        /// 商品详情信息
        /// </summary>
        public string offerDetail { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string subject { get; set; }

        /// <summary>
        /// 图片地址	["http://img.china.alibaba.com/img/ibank/2011/736/195/418591637_1146240514.jpg","http://img.china.alibaba.com/img/ibank/2011/736/195/418591637_1146240514.jpg","http://img.china.alibaba.com/img/ibank/2011/736/195/418591637_1146240514.jpg"]
        /// </summary>
        public string[] imageUriList { get; set; }

        /// <summary>
        /// 运费类型。T（运费模板） D（运费说明） F（卖家承担运费）
        /// </summary>
        public string freightType { get; set; }

        /// <summary>
        /// 发货地址ID
        /// </summary>
        public int sendGoodsAddressId { get; set; }

        /// <summary>
        /// 物流模板。卖家承担时模板ID为61
        /// </summary>
        public int freightTemplateId { get; set; }

        /// <summary>
        /// 单位重量
        /// </summary>
        public int offerWeight { get; set; }

        /// <summary>
        /// SKU信息。message:OfferSkuParam	"skuList":[{"amountOnSale":11,"specAttributes":{"1234":"value1","287":"value2","price":123}},{"amountOnSale":11,"specAttributes":{"1234":"value1","287":"value2","price":123} }]
        /// </summary>
        public OfferSkuParam[] skuList { get; set; }

        /// <summary>
        /// sku图片	"skuPics":{"3216":[{"\u767d\u8272":"http://img.china.alibaba.com/img/ibank/2013/242/222/926222242_648103749.jpg"},{"\u9ec4\u8272":"http://img.china.alibaba.com/img/ibank/2013/642/128/907821246_648103749.jpg"},{"\u9ed1\u8272":"http://img.china.alibaba.com/img/ibank/2013/988/206/888602889_648103749.jpg"}]}
        /// </summary>
        public List<Dictionary<string, List<IDictionary<string,string>>>> skuPics{get;set;}

    }
}
