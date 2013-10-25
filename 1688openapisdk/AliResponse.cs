using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk
{
    public abstract class AliResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public string error_code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string error_message { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        public string exception { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// 返回总数
        /// </summary>
        public int total { get; set; }

        /// <summary>
        /// 未序列化原始字符串
        /// </summary>
        public string body { get; set; }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        public bool IsError
        {
            get
            {
                return !string.IsNullOrEmpty(this.error_code);
            }
        }
    }

}
