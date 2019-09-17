using System;
using System.Collections.Generic;
using System.Linq;

namespace LogTerminal
{
    /// <summary>
    /// 日志分组工具
    /// filebeat提供的日志是基于行的，需要吧基于行的日志 按照单条日志进行分组（一个逻辑的日志 可能会有多行）
    /// </summary>
    class LogGrouper
    {
        public IList<LogGroup> Group(IList<LogInfo> logs)
        {

            InitLogsWithSerialNo(logs);

            var groupLogs = GroupLogs(logs);

            return groupLogs.OrderByDescending(x => x.Time).ToList();
        }

        private IList<LogGroup> GroupLogs(IList<LogInfo> logs)
        {
            var logGroups = new List<LogGroup>();

            var originalGroups = logs.GroupBy(x => x.File);
            foreach (var originalGroup in originalGroups)
            {
                var orderedLogs = originalGroup.OrderBy(x => x.SerialNo).ToList();

                LogGroup logGroup = null;
                foreach (var orderedLog in orderedLogs)
                {
                    if (orderedLog.MessageTime.HasValue)
                    {
                        logGroup = new LogGroup()
                        {
                            MessageWithStackTrace = orderedLog.Message,
                            App = orderedLog.GetApp(),
                            Time = orderedLog.MessageTime.Value,
                            Level = orderedLog.Level
                        };
                        logGroups.Add(logGroup);
                        continue;
                    }

                    if (logGroup != null)
                    {
                        logGroup.MessageWithStackTrace += Environment.NewLine;
                        logGroup.MessageWithStackTrace += orderedLog.Message;
                    }
                }
            }
            return logGroups;
        }

        private void InitLogsWithSerialNo(IList<LogInfo> logs)
        {
            var serialNo = 1;
            foreach (var logInfo in logs)
            {
                logInfo.Init(serialNo++);
            }
        }
    }
}
