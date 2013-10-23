using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _1688openapisdk
{
    /// <summary>
    /// 日志打点的简单实现。
    /// </summary>
    class DefaultAliLogger:IAliLogger
    {
        public const string LOG_FILE_NAME = "alisdk.log";
        public const string DATETIME_FORMAT = "yyyy-MM-dd HH:mm:ss";

        static DefaultAliLogger()
        {
            try
            {
                Trace.Listeners.Add(new TextWriterTraceListener(LOG_FILE_NAME));
            }
            catch (Exception e)
            {
                Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            }
            Trace.AutoFlush = true;
        }

        public void Error(string message)
        {
            Trace.WriteLine(message, DateTime.Now.ToString(DATETIME_FORMAT) + " ERROR");
        }

        public void Warn(string message)
        {
            Trace.WriteLine(message, DateTime.Now.ToString(DATETIME_FORMAT) + " WARN");
        }

        public void Info(string message)
        {
            Trace.WriteLine(message, DateTime.Now.ToString(DATETIME_FORMAT) + " INFO");
        }
    }
}
