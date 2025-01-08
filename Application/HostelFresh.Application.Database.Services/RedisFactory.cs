using HostelFresh.Application.Abstractions.Factories;
using HostelFresh.Shared.Configurations;
using Microsoft.Extensions.Options;
using StackExchange.Redis;

namespace HostelFresh.Application.Database.Services
{
    /// <inheritdoc cref="IRedisFactory"/>
    public class RedisFactory : IRedisFactory
    {
        #region CTOR
        /// <inheritdoc cref="RedisConfiguration"/>
        private readonly RedisConfiguration _redisConfiguration;

        /// <inheritdoc cref="IConnectionMultiplexer"/>
        private IConnectionMultiplexer? _connection;

        public RedisFactory(IOptions<RedisConfiguration> redisConfiguration)
        {
            _redisConfiguration = redisConfiguration.Value;
        }

        #endregion

        public IConnectionMultiplexer CreateConnection()
        {
            if (_redisConfiguration.ConnectionString == null)
            {
                throw new InvalidOperationException("Not set connection for Redis");
            }

            if (_connection == null || !_connection.IsConnected)
            {
                _connection = ConnectionMultiplexer.Connect(_redisConfiguration.ConnectionString);
            }

            return _connection;
        }
    }
}
