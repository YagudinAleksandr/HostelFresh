using HostelFresh.Application.Abstractions.Entities;

namespace HostelFresh.Domain.Entities.Events
{
    /// <summary>
    /// Событие удаления <see cref="IEventEntity"/>
    /// </summary>
    public class DeleteEntity : IEventEntity
    {
        public string Id { get; set; } = null!;

        /// <summary>
        /// Данные
        /// </summary>
        public string Data { get; set; } = null!;
    }
}
