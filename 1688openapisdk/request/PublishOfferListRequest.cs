using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;
using _1688openapisdk.domain;


namespace _1688openapisdk.request
{
    public class PublishOfferListRequest : IAliRequest<PublishOfferListResponse>
    {

        /// <summary>
        /// 商品所属类型（ALL：所有产品信息、SALE：供应信息、BUY：求购信息）
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 商品发布类目ID
        /// </summary>
        public long categoryId { get; set; }

        /// <summary>
        /// 卖家自定义的商品分类ID，多个之间用“,”分隔
        /// </summary>
        public string groupIds { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数;默认值为1，即返回第一页数据。
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// 返回offer列表结果集分页条数。取值范围:大于零的整数;最大值：200；默认值：35。
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// 格式:yyyy-MM-dd HH:mm:ss；1、如果传了时间戳参数，则按增量返回，即返回按指定获取条件且对应商品信息的最近更新时间(GMTModified)晚于该时间戳的商品列表信息。2、如果没有传时间戳参数，则取所有的满足条件的商品信息；
        /// </summary>
        public string timeStamp { get; set; }

        /// <summary>
        /// 只支持gmt_modify	gmt_modified:asc|desc
        /// </summary>
        public string orderBy { get; set; }

        /// <summary>
        /// 自定义返回字段，字段为offerDetailInfo子集。多个字段以半角','分隔。其中如下参数无法通过该API获得：amountOnSale、details、detailsUrl、saledCount、skuArray、termOfferProcess、tradingType
        /// </summary>
        public string[] returnFields { get; set; }

        public string access_token { get; set; }


        string IAliRequest<PublishOfferListResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offer.getPublishOfferList/";
        }

        IDictionary<string, string> IAliRequest<PublishOfferListResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("type", this.type);
            if (this.categoryId != 0)
            {
                parameters.Add("categoryId", this.categoryId.ToString());
            }
            if (this.groupIds != null)
            {
                parameters.Add("groupIds", this.groupIds);
            }
            if (this.page != 0)
            {
                parameters.Add("page", this.page.ToString());
            }
            if (this.pageSize != 0)
            {
                parameters.Add("pageSize", this.pageSize.ToString());
            }
            if (this.timeStamp != null)
            {
                parameters.Add("timeStamp", this.timeStamp);
            }
            if (this.orderBy != null)
            {
                parameters.Add("orderBy", this.orderBy);
            }
            if (this.returnFields != null)
            {
                parameters.Add("returnFields", String.Join(",",this.returnFields));
            }

            parameters.Add("access_token", this.access_token);

            return parameters;
        }

        void IAliRequest<PublishOfferListResponse>.Validate()
        {
            if (this.type == null || this.returnFields == null || this.access_token == null)
            {
                throw new AliException("type , returnFields ,access_token   must not be null");
            }
        }

        object IAliRequest<PublishOfferListResponse>.GetReturnType()
        {
            return typeof(List<OfferDetailInfo>);
        }
    }
}
