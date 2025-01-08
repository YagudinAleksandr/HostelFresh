using EventStore.Client;
using HostelFresh.Application.Abstractions.Factories;
using HostelFresh.Shared.Configurations;
using Microsoft.Extensions.Options;

namespace HostelFresh.Application.Database.Services
{
    /// <inheritdoc cref="IEventStoreFactory"></inheritdoc>
    public class EventStoreFactory : IEventStoreFactory
    {
        #region CTOR
        private readonly EventStoreConfiguration _configuration;

        public EventStoreFactory(IOptions<EventStoreConfiguration> configuration)
        {
            _configuration = configuration.Value;
        }
        #endregion

        public EventStoreClient CreateClient()
        {
            if (_configuration.ConnectionString == null)
            {
                throw new InvalidOperationException("Not set connection string for EventStore");
            }

            var settings = EventStoreClientSettings.Create(_configuration.ConnectionString);

            return new EventStoreClient(settings);
        }
    }
}
