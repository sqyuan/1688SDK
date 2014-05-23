using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.userdefinecategory;

namespace _1688openapisdk.request.userdefinecategory
{
    /// <summary>
    /// 阿里巴巴中国网站会员开启或关闭自定义分类功能 offerGroup.set -- version: 1
    /// </summary>
    public class OfferGroupSetRequest : IAliRequest<OfferGroupSetResponse>
    {
        public string access_token { get; set; }

        /// <summary>
        /// on或者off，on对应设置显示标记的开启，即：显示；off对应显示标记的关闭，即：不显示
        /// </summary>
        public string switchType { get; set; }

        string IAliRequest<OfferGroupSetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/offerGroup.set/";
        }

        IDictionary<string, string> IAliRequest<OfferGroupSetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("switchType", this.switchType);
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<OfferGroupSetResponse>.Validate()
        {
            if (this.switchType == null)
            {
                throw new AliException("switchType must not be null");
            }
        }

        object IAliRequest<OfferGroupSetResponse>.GetReturnType()
        {
            return typeof(OfferGroupSetResponse);
        }
    }
}
