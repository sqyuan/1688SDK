﻿using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.customer;

namespace _1688openapisdk.response.customer
{
    public class AcrmCustomerTradeGetResponse:AliResponse
    {
        public Relation[] models { get; set; }

        public int resultCode { get; set; }
    }
}
