using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.member;
using _1688openapisdk.domain.member;

namespace _1688openapisdk.request.member
{
    /// <summary>
    /// 获取阿里巴巴阿中国网站会员诚信信息。包括诚信通和诚信保障相关数据 creditInfo.get -- version: 1
    /// </summary>
    public class CreditInfoGetRequest : IAliRequest<CreditInfoGetResponse>
    {
        /// <summary>
        /// 会员ID，多个ID半角用分号连接，如：test1;test2 最多可以传200个会员ID
        /// </summary>
        public string memberIds { get; set; }

        /// <summary>
        /// SMALL 小图标；STANDARD 标准图标；WINPORT 旺铺图标；CREDIT 信用标识（默认值）；LARGE_TRANSPARENT 透明图标；SMALL_SEARCH 搜索引擎页面展示诚信通logo图标
        /// </summary>
        public string logoStyle { get; set; }

        string IAliRequest<CreditInfoGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/creditInfo.get/";
        }

        IDictionary<string, string> IAliRequest<CreditInfoGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberIds", this.memberIds);
            if (this.logoStyle != null)
            {
                parameters.Add("logoStyle", logoStyle);
            }
            return parameters;
        }

        void IAliRequest<CreditInfoGetResponse>.Validate()
        {
            if (this.memberIds == null)
            {
                throw new AliException("memberIds must not be null");
            }
        }

        object IAliRequest<CreditInfoGetResponse>.GetReturnType()
        {
            return typeof(List<CreditInfo>);
        }
    }
}
