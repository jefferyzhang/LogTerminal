﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using LogTerminal.Infrastructure;

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
        /// <param name="app"></param>
        /// <returns></returns>
        public LogInfos GetRecentlyLogs(string logLevel, string app)
        {
            var recentlyLogs = _logRepository.GetRecentlyLogs(MaxLogRows);
            var lastLog = recentlyLogs.LastOrDefault();

            recentlyLogs = recentlyLogs
                .WhereIf(logLevel.IsNotNullOrWhiteSpace(), x => x.Message.Contains(logLevel))
                .WhereIf(app.IsNotNullOrWhiteSpace(), x => x.GetApp().Contains(app))
                .ToList();

            return new LogInfos(recentlyLogs, lastLog);
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

        public IList<LogGroup> FilterLogs(IList<LogGroup> logs, DateTime begin, DateTime end, string logLevel, string app, string keyword)
        {
            return logs
                .Where(x => begin <= x.Time && x.Time <= end)
                .WhereIf(logLevel.IsNotNullOrWhiteSpace(), x => x.Level == logLevel)
                // ReSharper disable once AssignNullToNotNullAttribute
                .WhereIf(app.IsNotNullOrWhiteSpace(), x => x.App.Contains(app))
                // ReSharper disable once AssignNullToNotNullAttribute
                .WhereIf(keyword.IsNotNullOrWhiteSpace(), x => x.Message.Contains(keyword))
                .ToList();
        }
    }
}
