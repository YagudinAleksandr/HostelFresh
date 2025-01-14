using HostelFresh.Application.Abstractions.Entities;

namespace HostelFresh.Domain.Entities.Events
{
    /// <summary>
    /// Создание события <see cref="IEventEntity"/>
    /// </summary>
    public class CreateEvent : IEventEntity
    {
        public string Id { get; set; } = null!;

        /// <summary>
        /// Новые данные
        /// </summary>
        public string NewData { get; set; } = null!;
    }
}
