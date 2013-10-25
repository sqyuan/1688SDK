using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.response.photoalbum
{
    public class IbankImageDeleteByIdsResponse:AliResponse
    {
        public ImageDeleteResult[] toReturn { get; set; }
    }
}
