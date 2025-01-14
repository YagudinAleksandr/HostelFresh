using EventStore.Client;
using HostelFresh.Application.Abstractions.Entities;
using HostelFresh.Application.Abstractions.Factories;
using HostelFresh.Application.Abstractions.Repositories;
using HostelFresh.Shared.Enums;
using System.Text.Json;

namespace HostelFresh.Infrastructure.Repositories
{
    /// <inheritdoc cref="IEventRepository{TEntity}"/>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    public class EventRepository<TEntity> : IEventRepository<TEntity> where TEntity : class, IEventEntity
    {
        #region CTOR
        /// <inheritdoc cref="IEventStoreFactory"/>
        private readonly IEventStoreFactory _eventStoreFactory;

        /// <inheritdoc cref="EventStoreClient"/>
        private readonly EventStoreClient _client;

        public EventRepository(IEventStoreFactory eventStoreFactory)
        {
            _eventStoreFactory = eventStoreFactory;
            _client = _eventStoreFactory.CreateClient();
        }
        #endregion

        public async Task AddEvent(EventStreamTypes eventStream, EventTypes eventType, TEntity entity)
        {
            var data = JsonSerializer.SerializeToUtf8Bytes(entity);

            var eventPayload = new EventData(Uuid.NewUuid(), nameof(eventType), data);

            await _client.AppendToStreamAsync($"{nameof(eventStream)}-{entity.Id}", StreamState.Any, new[] { eventPayload });
        }


        public async Task<IReadOnlyCollection<TEntity>> GetAllEvents(EventStreamTypes eventStream, EventTypes type, string id)
        {
            var result = _client.ReadStreamAsync(Direction.Forwards, $"{nameof(eventStream)}-{id}", StreamPosition.Start);

            var events = new List<TEntity>();

            await foreach(var resolveData in result)
            {
                if(resolveData.Event.EventType == nameof(type))
                {
                    var eventData = JsonSerializer.Deserialize<TEntity>(resolveData.Event.Data.Span);

                    if (eventData != null)
                    {
                        events.Add(eventData);
                    }
                }
            }

            return events;
        }
    }
}
