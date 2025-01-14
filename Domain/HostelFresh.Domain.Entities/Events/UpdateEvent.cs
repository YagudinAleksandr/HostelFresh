using HostelFresh.Application.Abstractions.Entities;

namespace HostelFresh.Domain.Entities.Events
{
    /// <summary>
    /// Событие обновления <see cref="IEventEntity"/>
    /// </summary>
    public class UpdateEvent : IEventEntity
    {
        public string Id { get; set; } = null!;

        /// <summary>
        /// Новые данные
        /// </summary>
        public string NewData { get; set; } = null!;

        /// <summary>
        /// Старые данные
        /// </summary>
        public string OldData { get; set; } = null!;
    }
}
