using EventStore.Client;

namespace HostelFresh.Application.Abstractions.Factories
{
    /// <summary>
    /// Создание контекста EventStore
    /// </summary>
    public interface IEventStoreFactory
    {
        /// <summary>
        /// Создание клиента
        /// </summary>
        /// <returns>Клиент EventStore</returns>
        EventStoreClient CreateClient();
    }
}
