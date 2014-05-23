using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.category;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    /// 本接口实现通过输入关键词,搜索相关的类目ID
    /// </summary>
    public class CategorySearchRequest : IAliRequest<CategorySearchResponse>
    {
        /// <summary>
        /// 搜索关键词
        /// </summary>
        public string keyWord { get; set; }

        string IAliRequest<CategorySearchResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/category.search/";
        }

        IDictionary<string, string> IAliRequest<CategorySearchResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("keyWord", this.keyWord);
            return parameters;
        }

        void IAliRequest<CategorySearchResponse>.Validate()
        {
            if (this.keyWord == null)
            {
                throw new AliException("keyWord must not be null");
            }
        }

        object IAliRequest<CategorySearchResponse>.GetReturnType()
        {
           return typeof(List<int>);
        }
    }
}
