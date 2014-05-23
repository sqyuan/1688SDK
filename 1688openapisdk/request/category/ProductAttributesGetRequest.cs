using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.category;
using _1688openapisdk.domain.category;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    /// 本接口实现通过数据接口的形式，通过输入中文站大市场发布的叶子类目，返回其对应的产品属性信息（建议使用API“根据类目ID获取类目发布属性信息offerPostFeatures.get ”，获得所有发布相关属性信息）
    /// </summary>
    public class ProductAttributesGetRequest : IAliRequest<ProductAttributesGetResponse>
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        public long categoryID { get; set; }

        string IAliRequest<ProductAttributesGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/productAttributes.get/";
        }

        IDictionary<string, string> IAliRequest<ProductAttributesGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("categoryID", this.categoryID.ToString());
            return parameters;
        }

        void IAliRequest<ProductAttributesGetResponse>.Validate()
        {
            if (this.categoryID == 0)
            {
                throw new AliException("categoryID must not be null");
            }
        }

        object IAliRequest<ProductAttributesGetResponse>.GetReturnType()
        {
            return typeof(List<ProductAttributesInfo>);
        }
    }
}
