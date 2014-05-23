using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.search;

namespace _1688openapisdk.domain.search
{
    /// <summary>
    /// search.category.cheating -- version: 1
    /// 用户在发布offer时候，需要选择对应的发布类目，类目作弊就是用来检测选择的类目跟发布的offer信息是否匹配
    /// </summary>
    public class SearchCategoryCheatingRequest : IAliRequest<SearchCategoryCheatingResponse>
    {
        /// <summary>
        /// 卖家id,对应为该offer的旺铺userid
        /// </summary>
        public string userid { get; set; }

        /// <summary>
        /// Offer标题,对应为offer的标题，字段名为title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Offer 发布类目id,对应为offer的发布类目id，字段名为catid
        /// </summary>
        public string catid { get; set; }


        string IAliRequest<SearchCategoryCheatingResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/search.category.cheating/";
        }

        IDictionary<string, string> IAliRequest<SearchCategoryCheatingResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("userid", this.userid);
            parameters.Add("title", this.title);
            parameters.Add("catid", this.catid);
            return parameters;
        }

        void IAliRequest<SearchCategoryCheatingResponse>.Validate()
        {
            if (this.userid == null || this.title == null || this.catid == null)
            {
                throw new AliException("userid, title  ,catid   must not be null");
            }
        }

        object IAliRequest<SearchCategoryCheatingResponse>.GetReturnType()
        {
            return typeof(SearchCategoryCheatingResponse);
        }
    }
}
