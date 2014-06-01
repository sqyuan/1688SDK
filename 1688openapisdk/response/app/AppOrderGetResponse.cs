using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.app;
using Jayrock.Json;
using System.IO;

namespace _1688openapisdk.response.app
{
    public class AppOrderGetResponse:AliResponse
    {

        public IsvOrderItemDto[] returnValue { get; set; }

        public AppOrderGetResponse format()
        {
            if (string.IsNullOrEmpty(this.body))
            {
                return null;
            }
            return (AppOrderGetResponse)Jayrock.Json.Conversion.JsonConvert.Import(typeof(AppOrderGetResponse), this.body);

            
        }
    }
}
