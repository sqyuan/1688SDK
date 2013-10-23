using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk
{
    /// <summary>
    /// Ali客户端。
    /// </summary>
    public interface IAliClient
    {
        /// <summary>
        /// 执行Ali公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Ali API请求</param>
        /// <returns>领域对象</returns>
        T Execute<T>(IAliRequest<T> request) where T : AliResponse;

        /// <summary>
        /// 执行Ali隐私API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Ali API请求</param>
        /// <param name="access_token">用户会话码</param>
        /// <returns>领域对象</returns>
        T Execute<T>(IAliRequest<T> request, string accessToken) where T : AliResponse;

        /// <summary>
        /// 执行Ali隐私API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Ali API请求</param>
        /// <param name="access_token">用户会话码</param>
        /// <param name="timestamp">请求时间戳</param>
        /// <returns>领域对象</returns>
        T Execute<T>(IAliRequest<T> request, string accessToken, DateTime timestamp) where T : AliResponse;
    }

}
