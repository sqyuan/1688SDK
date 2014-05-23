using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.category;
using _1688openapisdk.domain.category;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    /// 根据类目ID获取商品发布类目信息
    /// </summary>
    public class CategoryGetPostCatListRequest : IAliRequest<CategoryGetPostCatListResponse>
    {

        /// <summary>
        /// 类目ID列表，支持多个ID批量查询，多个ID以半角冒逗分隔
        /// </summary>
        public string catIDs { get; set; }

        string IAliRequest<CategoryGetPostCatListResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/category.getPostCatList/";
        }

        IDictionary<string, string> IAliRequest<CategoryGetPostCatListResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("catIDs", this.catIDs);
            return parameters;
        }

        void IAliRequest<CategoryGetPostCatListResponse>.Validate()
        {
            if (this.catIDs == null)
            {
                throw new AliException("catIDs must not be null");
            }
        }

        object IAliRequest<CategoryGetPostCatListResponse>.GetReturnType()
        {
            return typeof(List<OfferCatsInfo>);
        }
    }
}
