using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response.app;

namespace _1688openapisdk.request.app
{
    /// <summary>
    /// ISV获取自己名下的应用最近一个月的订购的订单信息列表。 app.order.get -- version: 1
    /// </summary>
    public class AppOrderGetRequest : IAliRequest<AppOrderGetResponse>
    {
        /// <summary>
        /// 订单详细状态 audit_pass:审核通过，issue_ready：待发布，service：服务中，suspend：挂起 arrear_suspend：欠费挂起，closed：关闭，cancel：作废	["issue_ready","service"]	
        /// </summary>
        public string[] bizStatusExts { get; set; }

        /// <summary>
        /// 应用key	1111111
        /// </summary>
        public string appKey { get; set; }

        /// <summary>
        /// 下单时间	20130509120000000+0800
        /// </summary>
        public DateTime gmtCreate { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 订单服务状态列表 B:服务前，S:服务中，P：挂起，E：关闭，C:作废	["S","E"]
        /// </summary>
        public string[] bizStatusList { get; set; }

        /// <summary>
        /// 每页大小（用于分页） 限制：小于等于50	30
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// 第几页 （用于分页）	5
        /// </summary>
        public int startIndex { get; set; }

        string IAliRequest<AppOrderGetResponse>.GetApiName()
        {
            return "param2/1/cn.alibaba.open/app.order.get/";
        }

        IDictionary<string, string> IAliRequest<AppOrderGetResponse>.GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("memberId", this.memberId);
            if (this.bizStatusExts != null)
            {
                parameters.Add("bizStatusExts", "[" + String.Join(",",this.bizStatusExts) + "]");
            }
            if (this.appKey != null)
            {
                parameters.Add("appKey", this.appKey);
            }
            if (this.gmtCreate != null)
            {
                parameters.Add("gmtCreate", this.gmtCreate.ToString("yyyyMMddHHmmss368+0800"));
            }
            if (this.bizStatusList != null)
            {
                parameters.Add("bizStatusList", "[" + String.Join(",",this.bizStatusList) + "]");
            }
            if (this.pageSize != null)
            {
                parameters.Add("pageSize", this.pageSize.ToString());
            }
            if (this.startIndex != null)
            {
                parameters.Add("startIndex", this.startIndex.ToString());
            }
            return parameters;
        }

        void IAliRequest<AppOrderGetResponse>.Validate()
        {
            if (this.appKey == null || this.gmtCreate == null)
            {
                throw new AliException("appKey or gmtCreate must not be null");
            }
        }

        object IAliRequest<AppOrderGetResponse>.GetReturnType()
        {
            return typeof(AppOrderGetResponse);
        }
    }
}
