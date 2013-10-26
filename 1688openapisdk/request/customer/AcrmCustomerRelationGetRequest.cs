using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.customer;
using _1688openapisdk.domain.customer;

namespace _1688openapisdk.request.customer
{
    /// <summary>
    /// 本接口实现阿里巴巴中文站登录会员，根据等级获取当前卖家的会员信息
    /// </summary>
    class AcrmCustomerRelationGetRequest : IAliRequest<AcrmCustomerRelationGetResponse>
    {
        /// <summary>
        /// 中文站memberid
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 1 = 普通会员 ，2 = 高级会员， 3 = VIP会员， 4 = 至尊VIP会员 ，0 取所有的
        /// </summary>
        public long level { get; set; }

        /// <summary>
        /// 默认10条 最大50条
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        public int pageNum { get; set; }

        public string access_token { get; set; }

        string IAliRequest<AcrmCustomerRelationGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/acrm.customer.relation.get/";
        }

        IDictionary<string, string> IAliRequest<AcrmCustomerRelationGetResponse>.GetParameters()
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
            if (this.level != 0)
            {
                parameters.Add("level", this.level.ToString());
            }
            parameters.Add("access_token", this.access_token);
            return parameters;
        }

        void IAliRequest<AcrmCustomerRelationGetResponse>.Validate()
        {
            if (this.memberId == null || this.level == 0)
            {
                throw new AliException("memberId and level must not be null");
            }
        }

        object IAliRequest<AcrmCustomerRelationGetResponse>.GetReturnType()
        {
            return typeof(List<Relation>);
        }
    }
}
