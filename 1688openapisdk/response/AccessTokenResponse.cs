using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk.response
{
    public class AccessTokenResponse:AliResponse
    {
        public string accessToken { get;set;}

        public string accessTokenTimeout { get; set; }

        public string aliId { get; set; }

        public string memberId { get; set; }

        public string resourceOwnerId { get; set; }

        public string uid { get; set; }
    }
}
