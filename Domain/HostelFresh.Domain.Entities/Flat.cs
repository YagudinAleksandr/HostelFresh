using HostelFresh.Application.Abstractions.Entities;

namespace HostelFresh.Domain.Entities
{
    /// <summary>
    /// Этаж
    /// </summary>
    public class Flat : IEntity<int>, IOrderedEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// ИД подъезда
        /// </summary>
        public int EnteranceId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Порядковый номер
        /// </summary>
        public int? OrderNumber { get; set; }

        /// <summary>
        /// Подъезд <see cref="Entities.Enterance"/>
        /// </summary>
        public virtual Enterance Enterance { get; set; } = null!;
    }
}
