using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using _1688openapisdk.orderpush.domain;

namespace _1688openapisdk.orderpush
{
    public class PushServiceController
    {
        /// <summary>
        /// 解析订单结果集
        /// </summary>
        /// <param name="param">请求get和post参数集，value需要进行Url decode</param>
        /// <returns></returns>
        public OrderModel parseJson(Dictionary<string, string> param,string SecurityKey)
        {
            OrderModel orderModel = new OrderModel();
            try
            {
                string returnsign = "";

                if (param["sign_method"].ToString().ToUpper() == "HMAC")
                {
                    returnsign = Sign.sign(param, SecurityKey);
                }
                else
                {

                    returnsign = Sign.signMD5(param, SecurityKey);
                }

                Dictionary<string, string> dContent = new Dictionary<string, string>();
                dContent.Add("content", param["content"].ToString());
                string returnSignContent = Sign.sign(dContent, SecurityKey);

                if (param["sign"].ToString() == returnsign)
                {
                    orderModel =  (OrderModel)Jayrock.Json.Conversion.JsonConvert.Import(typeof(OrderModel), param["content"]);
                    orderModel.retCode = 1;
                }
                else
                {
                    orderModel.retCode = -1;
                }
            }
            catch (Exception ex)
            {
                orderModel.retCode = 0;
            }
            return orderModel;
        }

    }

  
}

