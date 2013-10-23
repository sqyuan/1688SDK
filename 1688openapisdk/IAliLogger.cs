using System;
using System.Collections.Generic;
using System.Text;

namespace _1688openapisdk
{
    /// <summary>
    /// 日志打点接口。
    /// </summary>
    public interface IAliLogger
    {
        void Error(string message);
        void Warn(string message);
        void Info(string message);
    }
}
