using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain
{
    public class MemberInfo
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 会员状态。Enabled：有效; Disabled：无效
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 会员账户类型。true：诚信通会员；false：免费账户会员
        /// </summary>
        public bool isTP { get; set; }

        /// <summary>
        /// 是否开通了网站。true：已开通；false：未开通
        /// </summary>
        public bool haveSite { get; set; }

        /// <summary>
        /// 是否个人诚信通。true：个人诚信通会员；false：非个人诚信通会员
        /// </summary>
        public bool isPersonalTP { get; set; }

        /// <summary>
        /// 是否企业诚信通。true：企业诚信通会员；false：非企业诚信通会员
        /// </summary>
        public bool isEnterpriseTP { get; set; }

        /// <summary>
        /// 是否专业市场诚信通会员。true：专业市场诚信通会员；false：非专业市场诚信通会员
        /// </summary>
        public bool isMarketTP { get; set; }

        /// <summary>
        /// 是否ETC会员。true：ETC海外诚信通会员；false：非ETC海外诚信通会员
        /// </summary>
        public bool isETCTP { get; set; }

        /// <summary>
        /// 会员是否具有开通分销平台资格。true：具有分销平台资格；false：没有分销平台资格
        /// </summary>
        public bool haveDistribution { get; set; }

        /// <summary>
        /// 会员是否已经开通分销平台。true：已开通；false：未开通
        /// </summary>
        public bool isDistribution { get; set; }

        /// <summary>
        /// 是否绑定了手机登录。true：是；false：否
        /// </summary>
        public bool isMobileBind { get; set; }

        /// <summary>
        /// 是否绑定了Email登录。true：是；false：否
        /// </summary>
        public bool isEmailBind { get; set; }

        /// <summary>
        /// 是否具有预存款的权限。true：具有预存款权限；false：没有预存款权限
        /// </summary>
        public bool havePrecharge { get; set; }

        /// <summary>
        /// 是否已经开通预存款服务。true：已开通；false：未开通
        /// </summary>
        public bool isPrecharge { get; set; }

        /// <summary>
        /// 是否参加诚信保障。true：参加诚信保障；false：没有参加诚信保障
        /// </summary>
        public bool isCreditProtection { get; set; }

        /// <summary>
        /// 是否已发布公司库。true：已发布；false：未发布
        /// </summary>
        public bool isPublishedCompany { get; set; }

        /// <summary>
        /// 是否绑定支付宝账户。true：已经绑定了支付宝；false：没有绑定支付宝
        /// </summary>
        public bool isAlipayBind { get; set; }

        /// <summary>
        /// 会员档案地址
        /// </summary>
        public string personalFileAddress { get; set; }

        /// <summary>
        /// 商铺地址
        /// </summary>
        public string winportAddress { get; set; }

        /// <summary>
        /// 诚信通指数。只有TP会员才有效
        /// </summary>
        public int trustScore { get; set; }

        /// <summary>
        /// 诚信档案地址。只有TP会员才有效
        /// </summary>
        public string trustProductAddress { get; set; }

        /// <summary>
        /// 公司库地址
        /// </summary>
        public string companyAddress { get; set; }

        /// <summary>
        /// 会员认证状态。1、如果该会员没有经过认证返回"认证信息：未经过第三方专业机构认证" 2、如果该会员经过了个人身份信息的实名认证返回"个人身份信息：已通过实名认证" 3、如果该会员经过了工商注册信息经过了第三方认证机构的认证，则返回"工商注册信息：已通过{第三方认证机构名称}认证"
        /// </summary>
        public string certificateStatus { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public string createTime { get; set; }

        /// <summary>
        /// 最近登录时间
        /// </summary>
        public string lastLogin { get; set; }

        /// <summary>
        /// 公司信息-公司名称
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        /// 公司信息-主营行业
        /// </summary>
        public string industry { get; set; }

        /// <summary>
        /// 公司信息-主营产品
        /// </summary>
        public string product { get; set; }

        /// <summary>
        /// 公司信息-网页地址
        /// </summary>
        public string homepageUrl { get; set; }

        /// <summary>
        /// 联系信息-姓名
        /// </summary>
        public string sellerName { get; set; }

        /// <summary>
        /// 联系信息-性别
        /// </summary>
        public string sex { get; set; }

        /// <summary>
        /// 联系信息-部门
        /// </summary>
        public string department { get; set; }

        /// <summary>
        /// 联系信息-职位
        /// </summary>
        public string openJobTitle { get; set; }

        /// <summary>
        /// 联系信息-电子邮箱
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 联系信息-司电话
        /// </summary>
        public string telephone { get; set; }

        /// <summary>
        /// 联系信息-传真
        /// </summary>
        public string fax { get; set; }

        /// <summary>
        /// 联系信息-手机
        /// </summary>
        public string mobilePhone { get; set; }

        /// <summary>
        /// 联系信息-所在地信息
        /// </summary>
        public AddressLocation addressLocation { get; set; }
    }
}
