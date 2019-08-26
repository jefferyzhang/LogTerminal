using System;

namespace LogTerminal
{
    /// <summary>
    /// 一条逻辑日志
    /// </summary>
    public class LogGroup
    {
        public DateTime Time { set; get; }

        public string App { set; get; }

        public string Level { set; get; }

        public string Message { set; get; }
    }
}
