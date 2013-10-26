using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.member
{
    /// <summary>
    /// 公司库信息
    /// </summary>
    public class CompanyInfo
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 公司库ID
        /// </summary>
        public string companyId { get; set; }

        /// <summary>
        /// 公司库状态。Auditing：等待审核；FailAudited：审核未通过；Published：已发布
        /// </summary>
        public string companyStatus { get; set; }

        /// <summary>
        /// 公司基本信息（对于匿名访客和非本人登录会员：只有公司库状态处于发布状态才能返回，下同）-公司名称
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        /// 公司基本信息-公司英文名
        /// </summary>
        public string companyNameEN { get; set; }

        /// <summary>
        /// 公司基本信息-企业类型
        /// </summary>
        public string legalStatus { get; set; }

        /// <summary>
        /// 公司基本信息-经营模式
        /// </summary>
        public string bizModel { get; set; }

        /// <summary>
        /// 公司基本信息-主要经营地点
        /// </summary>
        public string bizPlace { get; set; }

        /// <summary>
        /// 公司基本信息-主营产品
        /// </summary>
        public string productionService { get; set; }

        /// <summary>
        /// 公司基本信息-主营行业
        /// </summary>
        public string[] companyCategoryInfo { get; set; }

        /// <summary>
        /// 公司基本信息-公司简介
        /// </summary>
        public string profile { get; set; }

        /// <summary>
        /// 公司基本信息-公司网址
        /// </summary>
        public string homepageUrl { get; set; }

        /// <summary>
        /// 公司详细信息（对于匿名访客和非本人登录会员：只有公司库状态处于发布状态才能返回，下同）-注册资本
        /// </summary>
        public string regCapital { get; set; }

        /// <summary>
        /// 公司详细信息-公司成立时间
        /// </summary>
        public string establishedYear { get; set; }

        /// <summary>
        /// 公司详细信息-公司注册地
        /// </summary>
        public string foundedPlace { get; set; }

        /// <summary>
        /// 公司详细信息-法定代表人/负责人
        /// </summary>
        public string principal { get; set; }

        /// <summary>
        /// 公司详细信息-开户银行
        /// </summary>
        public string bank { get; set; }

        /// <summary>
        /// 公司详细信息-帐号
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// 公司详细信息-厂房面积
        /// </summary>
        public string factorySize { get; set; }

        /// <summary>
        /// 公司详细信息-员工人数
        /// </summary>
        public string employeesCount { get; set; }

        /// <summary>
        /// 公司详细信息-研发部门人数
        /// </summary>
        public string rndStaffNum { get; set; }

        /// <summary>
        /// 公司详细信息-品牌名称
        /// </summary>
        public string brandName { get; set; }

        /// <summary>
        /// 公司详细信息-月产量
        /// </summary>
        public string productionCapacity { get; set; }

        /// <summary>
        /// 公司详细信息-年营业额
        /// </summary>
        public string annualRevenue { get; set; }

        /// <summary>
        /// 公司详细信息-年进口额
        /// </summary>
        public string annualImportAmount { get; set; }

        /// <summary>
        /// 公司详细信息-年出口额
        /// </summary>
        public string annualExportAmount { get; set; }

        /// <summary>
        /// 公司详细信息-管理体系认证
        /// </summary>
        public string certification { get; set; }

        /// <summary>
        /// 公司详细信息-质量控制
        /// </summary>
        public string qaQc { get; set; }

        /// <summary>
        /// 公司详细信息-主要市场
        /// </summary>
        public string tradeRegionInfo { get; set; }

        /// <summary>
        /// 公司详细信息-主要客户群
        /// </summary>
        public string keyClients { get; set; }

        /// <summary>
        /// 公司详细信息-是否提供OEM代加工
        /// </summary>
        public string oemOdm { get; set; }

    }
}
