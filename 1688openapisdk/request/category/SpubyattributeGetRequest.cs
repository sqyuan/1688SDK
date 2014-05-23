using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.category;
using _1688openapisdk.domain.category;

namespace _1688openapisdk.domain.category
{
    /// <summary>
    /// 本接口实现通过数据接口的形式，通过输入用户填写的某个类目关键产品属性，返回该类目产品属性的SPU信息
    /// </summary>
    public class SpubyattributeGetRequest : IAliRequest<SpubyattributeGetResponse>
    {
        /// <summary>
        /// 叶子类目ID
        /// </summary>
        public long categoryID { get; set; }

        /// <summary>
        /// 产品关键属性和值，以“>”为分隔符，输入格式如示例 ：属性:属性值>属性:属性值	2176:BARDEN>3151:01B114E
        /// </summary>
        public string keyAttributes { get; set; }

        string IAliRequest<SpubyattributeGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/spubyattribute.get/";
        }

        IDictionary<string, string> IAliRequest<SpubyattributeGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("categoryID", this.categoryID.ToString());
            parameters.Add("keyAttributes", this.keyAttributes);
            return parameters; ;
        }

        void IAliRequest<SpubyattributeGetResponse>.Validate()
        {
            if (this.categoryID == 0)
            {
                throw new AliException("categoryID must not be null");
            }
        }

        object IAliRequest<SpubyattributeGetResponse>.GetReturnType()
        {
            return typeof(List<StandardSpu>);
        }
    }
}
