using System;
using System.Collections.Generic;
using System.Linq;

namespace LogTerminal
{
    public class LogInfos
    {
        private readonly IList<LogInfo> _logs;
        private readonly LogInfo _lastLog;

        public LogInfos(IList<LogInfo> logs,LogInfo lastLog )
        {
            _logs = logs;
            _lastLog = lastLog;
        }

        public string GetMessageForDisplay()
        {
            return string.Join(Environment.NewLine, _logs.Select(x => x.Message));
        }

        public LogInfo GetLastLog()
        {
            return _lastLog ?? LogInfo.Empty;
        }
    }

    public class LogGroup
    {
        public DateTime Time { set; get; }

        public string App { set; get; }

        public string Level { set; get; }

        public string Message { set; get; }
    }
}
