using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.search;

namespace _1688openapisdk.domain.search
{
    /// <summary>
    /// search.title.properties.inconsistent -- version: 1
    /// 用来判断，用户标题和属性中填写的信息是否一致，是否存在冲突的关键属性
    /// </summary>
    public class SearchTitlePropertiesInconsistentRequest : IAliRequest<SearchTitlePropertiesInconsistentResponse>
    {
        /// <summary>
        /// Offer 发布类目id,对应为offer的发布类目id，字段名为catid
        /// </summary>
        public string catid { get; set; }

        /// <summary>
        /// Offer标题,对应为offer的标题，字段名为title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Offer属性,对应为offer的属性，字段名为brief。brief的字段格式要求为： key：value 多个间空格分开
        /// 产品类别:洗衣液 品牌:Tide/汰渍 货号:TZ-200 类型:浓缩型 适用范围:所有衣物 香型:自然 净含量:200-350g/ml 产地:中国 箱装数量:30
        /// </summary>
        public string brief { get; set; }

        string IAliRequest<SearchTitlePropertiesInconsistentResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/search.title.properties.inconsistent/";
        }

        IDictionary<string, string> IAliRequest<SearchTitlePropertiesInconsistentResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("catid", this.catid);
            parameters.Add("title", this.title);
            parameters.Add("brief", this.brief);
            return parameters;
        }

        void IAliRequest<SearchTitlePropertiesInconsistentResponse>.Validate()
        {
            if (this.catid == null || this.title == null || this.brief == null)
            {
                throw new AliException("catid , title ,brief   must not be null");
            }
        }

        object IAliRequest<SearchTitlePropertiesInconsistentResponse>.GetReturnType()
        {
            return typeof(SearchTitlePropertiesInconsistentResponse);
        }
    }
}
