using System;
using System.Collections.Generic;
using System.Text;
using Jayrock.Json.Conversion;
using _1688openapisdk.response;
using Jayrock.Json;
using System.IO;
using System.Collections;

namespace _1688openapisdk
{
        /// <summary>
        /// 基于REST的Ali客户端。
        /// </summary>
        public class DefaultAliClient : IAliClient
        {
            public const string FORMAT = "_aop_responseFormat";
            public const string TIMESTAMP = "_aop_timestamp";
            public const string SIGN = "_aop_signature";
            public const string FORMAT_XML = "xml";
            public const string FORMAT_JSON = "json";
            public const string ACCESS_TOKEN = "access_token";

            public const string ACCESS_TOKEN_METHOD = "param2/1/system.oauth2/authn/";
           

            private string serverUrl;
            private string appKey;
            private string appSecret;
            private string format = FORMAT_JSON;
            private int timeout;

            private WebUtils webUtils;
            private IAliLogger aliLogger;
            private bool disableParser = false; // 禁用响应结果解释
            private bool disableTrace = false; // 禁用日志调试功能
            private Encoding encoding = Encoding.GetEncoding("utf-8");
            private IDictionary<string, string> systemParameters; // 设置所有请求共享的系统级参数

            #region DefaultAliClient Constructors

            public DefaultAliClient(string serverUrl, string appKey, string appSecret)
            {
                this.appKey = appKey;
                this.appSecret = appSecret;
                this.serverUrl = serverUrl;
                this.webUtils = new WebUtils();
                this.aliLogger = new DefaultAliLogger();
            }

            public DefaultAliClient(string serverUrl, string appKey, string appSecret, string format)
                : this(serverUrl, appKey, appSecret)
            {
                this.format = format;
            }

            #endregion


            public void SetTopLogger(IAliLogger aliLogger)
            {
                this.aliLogger = aliLogger;
            }

            public void SetTimeout(int timeout)
            {
                this.timeout = timeout;
            }

            public void SetDisableParser(bool disableParser)
            {
                this.disableParser = disableParser;
            }

            public void SetDisableTrace(bool disableTrace)
            {
                this.disableTrace = disableTrace;
            }

            public void SetSystemParameters(IDictionary<string, string> systemParameters)
            {
                this.systemParameters = systemParameters;
            }

            #region IAliClient Members

            public T Execute<T>(IAliRequest<T> request) where T : AliResponse
            {
                return Execute<T>(request, null);
            }

            public T Execute<T>(IAliRequest<T> request, string accessToken) where T : AliResponse
            {
                return Execute<T>(request, accessToken, DateTime.Now);
            }

            public T Execute<T>(IAliRequest<T> request, string accessToken, DateTime timestamp) where T : AliResponse
            {
                if (disableTrace)
                {
                    return DoExecute<T>(request, accessToken, timestamp);
                }
                else
                {
                    try
                    {
                        return DoExecute<T>(request, accessToken, timestamp);
                    }
                    catch (Exception e)
                    {
                        aliLogger.Error(this.serverUrl + "\r\n" + e.StackTrace);
                        throw e;
                    }
                }
            }

            #endregion

            private T DoExecute<T>(IAliRequest<T> request, string accessToken, DateTime timestamp) where T : AliResponse
            {
                // 提前检查业务参数
                try
                {
                    request.Validate();
                }
                catch (AliException e)
                {
                    return createErrorResponse<T>(e.ErrorCode, e.ErrorMsg);
                }

                // 添加协议级请求参数
                AliDictionary txtParams = new AliDictionary(request.GetParameters());

                // 添加签名参数
                string _aop_signature = Sign.sign(request.GetApiName() + this.appKey, txtParams, this.appSecret);
                txtParams.Add("_aop_signature", _aop_signature);
                
                //添加系统级参数
                txtParams.AddAll(this.systemParameters);


                // 是否需要上传文件
                //todo

                string body;
                System.Net.HttpWebResponse response = WebUtils.CreatePostHttpResponse(this.serverUrl + request.GetApiName() + this.appKey, txtParams, null, null, encoding, null);
                using (System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    body = reader.ReadToEnd();
                }

                // 解释响应结果
                T rsp;
                if (disableParser)
                {
                    rsp = Activator.CreateInstance<T>();
                   
                }
                else
                {
                    if (FORMAT_XML.Equals(format))
                    {
                        //todo
                        rsp = Activator.CreateInstance<T>();
                    }
                    else
                    {
                        if (request.GetApiName().Equals(ACCESS_TOKEN_METHOD))
                        {
                            rsp = (T)Jayrock.Json.Conversion.JsonConvert.Import(typeof(T), body);
                        }
                        else
                        {
                            JsonObject jsonObj = new JsonObject();
                            jsonObj.Import(new JsonTextReader(new StringReader(body)));
                            JsonObject responseObj = jsonObj["result"] as JsonObject;
                            bool code = (bool)responseObj["success"];
                            Int32 total = ((JsonNumber)responseObj["total"]).ToInt32();
                            if (!code && total == 0)
                            {
                                return createErrorResponse<T>(jsonObj["code"].ToString(), jsonObj["message"].ToString());
                            }
                            JsonArray toReturn = responseObj["toReturn"] as JsonArray;
                            if (((Type)request.GetReturnType()).FullName.StartsWith("System.Collections.Generic.List") || request.GetReturnType().GetType().IsArray)
                            {
                                rsp = (T)Jayrock.Json.Conversion.JsonConvert.Import(typeof(T), responseObj.ToString());
                            }
                            else
                            {
                                String newBody = "{toReturn:" + toReturn[0].ToString() + "}";
                                rsp = (T)Jayrock.Json.Conversion.JsonConvert.Import(typeof(T), newBody);
                            }
                            rsp.total = total;
                        }
                       
                    }
                }

                // 追踪错误的请求
                if (!disableTrace)
                {
                }

                return rsp;
            }

            private T createErrorResponse<T>(string errCode, string errMsg) where T : AliResponse
            {
                T rsp = Activator.CreateInstance<T>();
               

                if (FORMAT_XML.Equals(format))
                {
                }
                else
                {
                    IDictionary<string, object> errObj = new Dictionary<string, object>();
                    errObj.Add("error_code", errCode);
                    errObj.Add("error_message", errMsg);
                    IDictionary<string, object> root = new Dictionary<string, object>();
                    root.Add("error_response", errObj);

                    string body = JsonConvert.ExportToString(root);
                    
                }
                return rsp;
            }
        }
}
