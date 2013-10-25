using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.order
{
    public class WeightTariff
    {
        public string gmtModified { get; set; }

        public double nextWeight { get; set; }

        public string gmtCreate { get; set; }

        /// <summary>
        /// 物流模板id
        /// </summary>
        public int freightTemplateId { get; set; }

        public string areaId { get; set; }

        public int id { get; set; }

        public int nextWeightFee { get; set; }

        public int largeWeightPrice { get; set; }

        ///public bool default{get;set;}

        public double largeWeight { get; set; }

        public double firstWeight { get; set; }

        public long firstWeightFee { get; set; }
    }
}
