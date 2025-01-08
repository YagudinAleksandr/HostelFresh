using StackExchange.Redis;

namespace HostelFresh.Application.Abstractions.Factories
{
    /// <summary>
    /// Фабрика подключения к Redis
    /// </summary>
    public interface IRedisFactory
    {
        /// <summary>
        /// Создание контекста подключения к Redis
        /// </summary>
        /// <returns>Контекст подключения к Redis</returns>
        IConnectionMultiplexer CreateConnection();
    }
}
