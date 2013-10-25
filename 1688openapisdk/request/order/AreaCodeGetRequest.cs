using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.order;

namespace _1688openapisdk.request.order
{
    /// <summary>
    /// 获取省份编码信息
    /// </summary>
    public class AreaCodeGetRequest : IAliRequest<AreaCodeGetResponse>
    {

        string IAliRequest<AreaCodeGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/areaCode.get/";
        }

        IDictionary<string, string> IAliRequest<AreaCodeGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            return parameters;
        }

        void IAliRequest<AreaCodeGetResponse>.Validate()
        {
           
        }

        object IAliRequest<AreaCodeGetResponse>.GetReturnType()
        {
            return typeof(AreaCodeGetResponse);
        }
    }
}
