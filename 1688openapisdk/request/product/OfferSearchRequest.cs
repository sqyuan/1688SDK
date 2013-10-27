using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.product;
using _1688openapisdk.domain;

namespace _1688openapisdk.request.product
{
    /// <summary>
    /// 
    /// </summary>
    public class OfferSearchRequest : IAliRequest<OfferSearchResponse>
    {
        /// <summary>
        /// Offer状态	published,(上线)TDB,deleted(删除),new(待审)
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 会员自定义类别ID
        /// </summary>
        public string groupIds { get; set; }

        /// <summary>
        /// 最小起批量
        /// </summary>
        public string quantityBegin { get; set; }

        /// <summary>
        /// 供应产品星级	1~5
        /// </summary>
        public string qualityLevel { get; set; }

        /// <summary>
        /// 价格区间	10~300
        /// </summary>
        public string price { get; set; }

        /// <summary>
        /// 城市中文名	杭州
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 省份中文名	浙江
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 最低销售额
        /// </summary>
        public int soldQuantity { get; set; }

        /// <summary>
        /// 诚信保障金额	1000~30000
        /// </summary>
        public string creditMoney { get; set; }

        /// <summary>
        /// 诚信通开能年限	1~5
        /// </summary>
        public string tpYear { get; set; }

        /// <summary>
        /// 供货地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 查询修改时间结束时刻.要求 gmtModifedEnd 晚于 gmtModifiedBegin	日期编码格式：yyyyMMddHHmmssSSSZ， 如：20120626175014384+0800 ， 不要忘了对值进行urlEncode
        /// </summary>
        public string gmtModifiedEnd { get; set; }

        /// <summary>
        /// 查询修改时间结束时刻.要求 gmtModifedBegin 早于 gmtModifiedEnd	日期编码格式：yyyyMMddHHmmssSSSZ， 如：20120626175014384+0800 ， 不要忘了对值进行urlEncode	
        /// </summary>
        public string gmtModifiedBegin { get; set; }

        /// <summary>
        /// 当分页查询时指定请求的数据页
        /// </summary>
        public int pageNo { get; set; }

        /// <summary>
        /// 单页条数
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// 搜索returnFields的最大集合[ "offerId", "type", "postCategryId", "memberId", "subject", "qualityLevel", "imageList", "isOfferSupportOnlineTrade", "isSupportMix", "unit", "priceUnit", "retailPrice", "gmtCreate", "gmtModified", "gmtExpire", "offerStatus", "gmtApproved", "gmtLastRepost", "amount", "privateOfferFields", "priceRanges", "sendGoodsId", "freightTemplateId", "productUnitWeight", "offerRemarkStat", "creditBalance", "isTpMember", "tpYear", "address", "province", "city", "quantityBegin" ]
        /// </summary>
        public string[] returnFields { get; set; }

        /// <summary>
        /// 排序字段：gmtexpire:asc|desc,gmt_modified:asc|desc	offerId:asc;tpYear;
        /// </summary>
        public string orderBy { get; set; }

        /// <summary>
        /// 搜索关键字，现在主要支持按标题搜索
        /// </summary>
        public string q { get; set; }

        /// <summary>
        /// 发布类目编号
        /// </summary>
        public long category { get; set; }

        /// <summary>
        /// 产品会员ID
        /// </summary>
        public string memberId { get; set; }

        public string access_token { get; set; }

        string IAliRequest<OfferSearchResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.search/";
        }

        IDictionary<string, string> IAliRequest<OfferSearchResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (this.status != null)
            {
                parameters.Add("status", this.status);
            }
            if (this.groupIds != null)
            {
                parameters.Add("groupIds", this.groupIds);
            }
            if (this.quantityBegin != null)
            {
                parameters.Add("quantityBegin", this.quantityBegin);
            }
            if (this.price != null)
            {
                parameters.Add("price", this.price);
            }
            if (this.pageSize != 0)
            {
                parameters.Add("pageSize", this.pageSize.ToString());
            }
            if (this.pageNo != 0)
            {
                parameters.Add("pageNo", this.pageNo.ToString());
            }
            if (this.city != null)
            {
                parameters.Add("city", this.city);
            }
            if (this.province != null)
            {
                parameters.Add("province", this.province);
            }
            if (this.soldQuantity != 0)
            {
                parameters.Add("soldQuantity", this.soldQuantity.ToString());
            }
            if (this.creditMoney != null)
            {
                parameters.Add("creditMoney", this.creditMoney);
            }
            if (this.tpYear != null)
            {
                parameters.Add("tpYear", this.tpYear);
            }
            if (this.address != null)
            {
                parameters.Add("address", this.address);
            }
            if (this.gmtModifiedEnd != null)
            {
                parameters.Add("gmtModifiedEnd", this.gmtModifiedEnd);
            }
            if (this.gmtModifiedBegin != null)
            {
                parameters.Add("gmtModifiedBegin", this.gmtModifiedBegin);
            }
            
            if (this.orderBy != null)
            {
                parameters.Add("orderBy", this.orderBy);
            }
            if (this.returnFields != null)
            {
                parameters.Add("returnFields", String.Join(",", this.returnFields));
            }
            if (this.category != 0)
            {
                parameters.Add("category", this.category.ToString());
            }
            parameters.Add("memberId", this.memberId);
            parameters.Add("access_token", this.access_token);

            return parameters;
        }

        void IAliRequest<OfferSearchResponse>.Validate()
        {
            if (this.memberId == null || this.access_token == null)
            {
                throw new AliException("memberId ,access_token   must not be null");
            }
        }

        object IAliRequest<OfferSearchResponse>.GetReturnType()
        {
            return typeof(List<OfferDetailInfo>);
        }
    }
}
