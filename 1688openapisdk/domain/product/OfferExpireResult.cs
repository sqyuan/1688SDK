using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.domain.product
{
    public class OfferExpireResult
    {
        public long offerId { get; set; }

        public Boolean isSuccess { get; set; }

        public string failure { get; set; }

        public string GMTExpire { get; set; }

        public string GMTModified { get; set; }
    }
}
