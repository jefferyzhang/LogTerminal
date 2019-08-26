using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using LogTerminal;

namespace LogTerminal
{
    /// <summary>
    /// 日志服务
    /// </summary>
    public class LogService
    {
        private readonly LogRepository _logRepository;
        private static readonly int MaxLogRows = int.Parse(ConfigurationManager.AppSettings["fetch.batch.size"]);
        private readonly LogGrouper _logGrouper = new LogGrouper();

        public LogService(Profile profile)
        {
            _logRepository = new LogRepository(RedisConnectionFactory.Of(profile));
        }

        /// <summary>
        /// 获取最近日志
        /// </summary>
        /// <param name="logLevel"></param>
        /// <returns></returns>
        public LogInfos GetRecentlyLogs(string logLevel)
        {
            var recentlyLogs = _logRepository.GetRecentlyLogs(MaxLogRows);
            var lastLog = recentlyLogs.LastOrDefault();

            if (string.IsNullOrEmpty(logLevel) == false)
            {
                recentlyLogs = recentlyLogs.Where(x => x.Message.Contains(logLevel)).ToList();
            }

            return new LogInfos(recentlyLogs,lastLog);
        }

        /// <summary>
        /// 删除老日志
        /// </summary>
        public void RemoveOldLogs()
        {
            _logRepository.RemoveOldLogs();
        }

        /// <summary>
        /// 是否有新日志
        /// </summary>
        /// <param name="lastLog"></param>
        /// <returns></returns>
        public bool HasNewLog(LogInfo lastLog)
        {
            var curLastLog = _logRepository.GetLastLog() ?? LogInfo.Empty;
            return lastLog.Message != curLastLog.Message;
        }

        /// <summary>
        /// 获取所有日志
        /// </summary>
        /// <returns></returns>
        public IList<LogGroup> GetAllLogs()
        {
            var logInfos = _logRepository.GetAllLogs();
            return _logGrouper.Group(logInfos);
        }
    }
}
