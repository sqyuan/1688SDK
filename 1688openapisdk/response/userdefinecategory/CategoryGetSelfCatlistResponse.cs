using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.userdefinecategory;

namespace _1688openapisdk.response.userdefinecategory
{
    public class CategoryGetSelfCatlistResponse:AliResponse
    {
        public UserDefineCat toReturn { get; set; }
    }
}
