using System;
using LogTerminal.Infrastructure;

namespace LogTerminal
{
    /// <summary>
    /// 一条逻辑日志
    /// </summary>
    public class LogGroup
    {
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Time { set; get; }

        /// <summary>
        /// 应用
        /// </summary>
        public string App { set; get; }

        /// <summary>
        /// 日志级别
        /// </summary>
        public string Level { set; get; }

        /// <summary>
        /// 带堆栈信息的消息
        /// </summary>
        public string MessageWithStackTrace { set; get; }

        /// <summary>
        /// 日志消息体
        /// </summary>
        public string Message {
            get
            {
                string message = null;

                var messageStartPos = MessageWithStackTrace.IndexOf("Exception:");
                if (messageStartPos > 0)
                {
                    //如果是异常，获取从异常信息开始的部分
                    message = MessageWithStackTrace.Substring(messageStartPos);
                }
                else if (Level.IsNotNullOrWhiteSpace())
                {
                    //不是异常，则获取从日志级别开始后的部分
                    message = MessageWithStackTrace.Substring(MessageWithStackTrace.IndexOf(Level)+Level.Length);
                }
                return message;
            }
        }
    }
}
