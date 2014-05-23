using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.customer;
using _1688openapisdk.domain.customer;

namespace _1688openapisdk.domain.customer
{
    /// <summary>
    /// 本接口实现阿里巴巴中文站登录会员，根据标签获取当前卖家的会员信息
    /// </summary>
    public class AcrmCustomerGroupGetRequest : IAliRequest<AcrmCustomerGroupGetResponse>
    {
        /// <summary>
        /// 中文站memberid
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 分组id，可通过acrm.groups.get获得
        /// </summary>
        public long groupId { get; set; }

        /// <summary>
        /// 页面大小 默认最大20
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        public int pageNum { get; set; }

        public string access_token { get; set; }

        string IAliRequest<AcrmCustomerGroupGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/acrm.customer.group.get/";
        }

        IDictionary<string, string> IAliRequest<AcrmCustomerGroupGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            if (this.pageSize != 0)
            {
                parameters.Add("pageSize", this.pageSize.ToString());
            }
            if (this.pageNum != 0)
            {
                parameters.Add("pageNum", this.pageNum.ToString());
            }
            if (this.groupId != 0)
            {
                parameters.Add("groupId", this.groupId.ToString());
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<AcrmCustomerGroupGetResponse>.Validate()
        {
            if (this.memberId == null || this.groupId == 0)
            {
                throw new AliException("memberId and groupId must not be null");
            }
        }

        object IAliRequest<AcrmCustomerGroupGetResponse>.GetReturnType()
        {
            return typeof(List<Relation>);
        }
    }
}
