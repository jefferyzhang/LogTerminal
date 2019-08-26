using System;
using System.Configuration;
using StackExchange.Redis;

namespace LogTerminal
{
    /// <summary>
    /// Redis 连接工厂
    /// </summary>
    public class RedisConnectionFactory
    {
        private readonly Lazy<ConnectionMultiplexer> _redisConnectionMultiplexer;

        protected RedisConnectionFactory(string connectionSettingName)
        {
            var connecString = ConfigurationManager.AppSettings[connectionSettingName];
            _redisConnectionMultiplexer =
                new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(connecString));
        }

        private readonly int _defaultDb = int.Parse(ConfigurationManager.AppSettings["redis.db"]);

        public IDatabase GetConnection()
        {
            return _redisConnectionMultiplexer.Value.GetDatabase(_defaultDb);
        }

        public static RedisConnectionFactory TestConnectionFactory { get; } = new RedisConnectionFactory("redis.test");

        public static RedisConnectionFactory PreConnectionFactory { get; } = new RedisConnectionFactory("redis.pre");

        public static RedisConnectionFactory Of(Profile profile)
        {
            return profile == Profile.Test ? TestConnectionFactory : PreConnectionFactory;
        }
    }
}
