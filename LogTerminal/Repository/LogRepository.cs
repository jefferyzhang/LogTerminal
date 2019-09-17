using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace LogTerminal
{
    /// <summary>
    /// 日志仓库
    /// </summary>
    class LogRepository
    {
        private readonly IDatabase _db;

        private static readonly string LogKey = ConfigurationManager.AppSettings["log.key"];
        private static readonly int REDIS_MAX_CACHE_LINE = int.Parse(ConfigurationManager.AppSettings["redis.cache.line"]);
        private static readonly int TRIM_CACHE_BATCH_SIZE = 20;
        private static readonly int FETCH_BATCH_SIZE = 50;

        public LogRepository(RedisConnectionFactory redisConnectionFactory)
        {
            _db = redisConnectionFactory.GetConnection();
        }

        /// <summary>
        /// 获取最近的日志
        /// </summary>
        /// <param name="takeCount"></param>
        /// <returns></returns>
        public IList<LogInfo> GetRecentlyLogs(long takeCount)
        {
            var totalCount = _db.ListLength(LogKey);
            Debug.WriteLine("logs total count:"+ totalCount);

            if (totalCount <= 0)
            {
                return new List<LogInfo>();
            }
            takeCount = Math.Min(takeCount, totalCount);
             
            var redisValues = _db.ListRange(LogKey,totalCount-takeCount);
            return redisValues.Select(x => JsonConvert.DeserializeObject<LogInfo>(x)).ToList();
        }

        /// <summary>
        /// 删除老的日志
        /// </summary>
        public void RemoveOldLogs()
        {
            var totalCount = _db.ListLength(LogKey);
            if (totalCount > REDIS_MAX_CACHE_LINE + TRIM_CACHE_BATCH_SIZE)
            {
                _db.ListTrim(LogKey, totalCount - REDIS_MAX_CACHE_LINE, -1);
            }
        }

        /// <summary>
        /// 获取最新日志
        /// </summary>
        /// <returns></returns>
        public LogInfo GetLastLog()
        {
            return GetRecentlyLogs(1).FirstOrDefault();
        }

        /// <summary>
        /// 获取所有日志
        /// </summary>
        /// <returns></returns>
        public IList<LogInfo> GetAllLogs()
        {
            var result = new List<LogInfo>();

            var totalCount = _db.ListLength(LogKey);
            var skipLogCount = totalCount <= REDIS_MAX_CACHE_LINE ? 0 : totalCount - REDIS_MAX_CACHE_LINE;
            var startFetchIndex = skipLogCount;

            while (true)
            {
                var redisValues = _db.ListRange(LogKey, startFetchIndex, startFetchIndex + FETCH_BATCH_SIZE);
                result.AddRange(redisValues.Select(x => JsonConvert.DeserializeObject<LogInfo>(x)));

                if (redisValues.Length < FETCH_BATCH_SIZE)
                {
                    break;
                }
                startFetchIndex += FETCH_BATCH_SIZE;
            }

            return result;
        }
    }
}
