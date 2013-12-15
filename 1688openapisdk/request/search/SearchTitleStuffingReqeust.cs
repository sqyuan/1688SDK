using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.search;

namespace _1688openapisdk.request.search
{
    /// <summary>
    /// 标题堆砌，用来检测offer标题中是否存在堆砌多个关键词的情况，包括产品词堆砌，型号词堆砌，品牌堆砌等
    /// </summary>
    public class SearchTitleStuffingReqeust : IAliRequest<SearchTitleStuffingResponse>
    {
        public string query { get; set; }

        string IAliRequest<SearchTitleStuffingResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/search.title.stuffing/";
        }

        IDictionary<string, string> IAliRequest<SearchTitleStuffingResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("query", this.query);
            return parameters;
        }

        void IAliRequest<SearchTitleStuffingResponse>.Validate()
        {
            if (this.query == null)
            {
                throw new AliException("query must not be null");
            }
        }

        object IAliRequest<SearchTitleStuffingResponse>.GetReturnType()
        {
            return typeof(SearchTitleStuffingResponse);
        }
    }
}
