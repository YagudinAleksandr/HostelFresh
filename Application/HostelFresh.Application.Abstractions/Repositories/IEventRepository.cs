using HostelFresh.Application.Abstractions.Entities;
using HostelFresh.Shared.Enums;

namespace HostelFresh.Application.Abstractions.Repositories
{
    public interface IEventRepository<TEntity> where TEntity : class, IEventEntity
    {
        /// <summary>
        /// Создание события
        /// </summary>
        /// <param name="eventStream">Название потока <see cref="EventStreamTypes"/></param>
        /// <param name="eventType">Тип события <see cref="EventTypes"/></param>
        /// <param name="entity">Модель данных <typeparamref name="TEntity"/></param>
        Task AddEvent(EventStreamTypes eventStream,  EventTypes eventType, TEntity entity);

        /// <summary>
        /// Получение списка событий
        /// </summary>
        /// <param name="eventStream">Название потока <see cref="EventStreamTypes"/></param>
        /// <param name="type">Тип события <see cref="EventTypes"/></param>
        /// <param name="id">ИД сущности</param>
        /// <returns>Список событий</returns>
        Task<IReadOnlyCollection<TEntity>> GetAllEvents(EventStreamTypes eventStream, EventTypes type, string id);
    }
}
