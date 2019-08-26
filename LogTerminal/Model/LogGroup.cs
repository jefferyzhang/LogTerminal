using System;

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
        /// 日志消息体
        /// </summary>
        public string Message { set; get; }
    }
}
