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
    /// <summary>
    /// 
    ///  名称	类型	说明	可选
     /// topic	String	API发送接口名称	必选
     /// sign	String	签名串	必选
     /// sign_method	String	签名算法,md5 hmac，默认mds	必选
    ///  timestamp	String	时间戳，默认yyyy-MM-dd HH:mm:ss	必选
     /// user_id	String	卖家ID	1688没有
     /// app_key	String	应用的appkey	必选
     /// input_charset	String	字符编码	可选
     /// message_id	String	消息通知Id	必选
    ///  message_time	String	消息通知时间 YYYY-MM-DD hh:mm:ss	必选
    ///  content	String	业务参数内容，值是json或者XML格式化串	必选
    /// </summary>
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

