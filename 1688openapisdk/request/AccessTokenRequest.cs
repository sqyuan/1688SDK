using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.response;

namespace _1688openapisdk.request
{
    /// <summary>
    /// AccessTokenRequest
    /// </summary>
    public class AccessTokenRequest : IAliRequest<AccessTokenResponse>
    {
        public string account { get; set; }

        public string password { get; set; }

        public string GetApiName()
        {
            return "param2/1/system.oauth2/authn/";
        }

        public IDictionary<string, string> GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("loginIdType", "LOGIN_ID");
            parameters.Add("needRefreshToken", "false");
            parameters.Add("account", this.account);
            parameters.Add("password", this.password);
            return parameters;
        }

        public void Validate()
        {
            if (this.account == null || this.password == null)
            {
                throw new AliException("account and password must not be null");
            }
        }

        public object GetReturnType()
        {
            return typeof(AccessTokenResponse);
        }
    }
}
