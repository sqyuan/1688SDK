using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.category;
using _1688openapisdk.domain.category;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    /// 本接口实现通过数据接口的形式，通过大市场叶子类目id，获取该类目的发布类目路径
    /// </summary>
    public class CategoryGetCatePathRequest : IAliRequest<CategoryGetCatePathResponse>
    {
        /// <summary>
        /// 叶子类目ID
        /// </summary>
        public long categoryID { get; set; }

        string IAliRequest<CategoryGetCatePathResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/category.getCatePath/";
        }

        IDictionary<string, string> IAliRequest<CategoryGetCatePathResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("categoryID", this.categoryID.ToString());
            return parameters;
        }

        void IAliRequest<CategoryGetCatePathResponse>.Validate()
        {
            if (this.categoryID == 0)
            {
                throw new AliException("categoryID must not be null");
            }
        }

        object IAliRequest<CategoryGetCatePathResponse>.GetReturnType()
        {
            return typeof(List<OfferCatsInfo>);
        }
    }
}
