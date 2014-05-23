using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.response.userdefinecategory
{
    public class OfferGroupHasOpenedResponse:AliResponse
    {
        /// <summary>
        /// true：已开启；false：未开启
        /// </summary>
        public bool isOpened { get; set; }
    }
}
