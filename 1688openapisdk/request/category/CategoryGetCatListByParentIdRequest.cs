using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.category;
using _1688openapisdk.domain.category;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    /// 根据父类目ID获取其子类目信息
    /// </summary>
    public class CategoryGetCatListByParentIdRequest : IAliRequest<CategoryGetCatListByParentIResponse>
    {
        /// <summary>
        /// 父类目ID
        /// </summary>
        public long parentCategoryID { get; set; }

        /// <summary>
        /// 获取该父类目的所有子类目	取值“T” （取全部子类目信息）或 “F”（只取一级子类目信息），默认“F”。
        /// </summary>
        public string getAllChildren { get; set; }

        /// <summary>
        /// 0000-00-00
        /// </summary>
        public string timeStamp { get; set; }

        string IAliRequest<CategoryGetCatListByParentIResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/category.getCatListByParentId/";
        }

        IDictionary<string, string> IAliRequest<CategoryGetCatListByParentIResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("parentCategoryID", this.parentCategoryID.ToString());
            if (this.getAllChildren != null)
            {
                parameters.Add("getAllChildren", getAllChildren);
            }
            if (this.timeStamp != null)
            {
                parameters.Add("timeStamp", this.timeStamp);
            }
            return parameters;
        }

        void IAliRequest<CategoryGetCatListByParentIResponse>.Validate()
        {
            if (this.parentCategoryID == 0)
            {
                throw new AliException("parentCategoryID must not be null");
            }
        }

        object IAliRequest<CategoryGetCatListByParentIResponse>.GetReturnType()
        {
            return typeof(List<OfferCatsInfo>);
        }
    }
}
