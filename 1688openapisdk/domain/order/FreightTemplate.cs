using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.order
{
    public class FreightTemplate
    {
        public string gmtModified { get; set; }

        public string gmtCreate { get; set; }

        public WeightTariff[] weightTariffList{get;set;}

        public string memberId { get; set; }

        public string templateName { get; set; }
    }
}
