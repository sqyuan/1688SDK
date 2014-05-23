using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.userdefinecategory;

namespace _1688openapisdk.domain.userdefinecategory
{
    /// <summary>
    /// 获取指定会员（供应商）的自定义商品分类信息
    /// </summary>
    public class CategoryGetSelfCatlistRequest : IAliRequest<CategoryGetSelfCatlistResponse>
    {
        public string memberId { get; set; }

        string IAliRequest<CategoryGetSelfCatlistResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/category.getSelfCatlist/";
        }

        IDictionary<string, string> IAliRequest<CategoryGetSelfCatlistResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            return parameters;
        }

        void IAliRequest<CategoryGetSelfCatlistResponse>.Validate()
        {
            if (this.memberId == null)
            {
                throw new AliException("memberId must not be null");
            }
        }

        object IAliRequest<CategoryGetSelfCatlistResponse>.GetReturnType()
        {
            return typeof(CategoryGetSelfCatlistResponse);
        }
    }
}
