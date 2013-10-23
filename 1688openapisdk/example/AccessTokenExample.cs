using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.request;
using _1688openapisdk.response;

namespace _1688openapisdk.example
{
    class AccessTokenExample
    {
        static void Main(string[] args)
        {
            DefaultAliClient defaultAliClient = new DefaultAliClient("https://gw.open.1688.com/openapi/", "338249", "JpmpVnOvJb");
            AccessTokenRequest accessTokenRequest = new AccessTokenRequest();
            accessTokenRequest.account = "testfree66";
            accessTokenRequest.password = "1111112";
            AccessTokenResponse accessTokenResponse = defaultAliClient.Execute(accessTokenRequest);
            Jayrock.Json.JsonTextWriter writer = new Jayrock.Json.JsonTextWriter();
            Jayrock.Json.Conversion.JsonConvert.Export(accessTokenResponse, writer);
            string str = writer.ToString();
            Console.WriteLine(str);
        }
    }
}
