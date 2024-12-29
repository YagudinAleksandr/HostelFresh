using HostelFresh.Application.Abstractions.Entities;

namespace HostelFresh.Domain.Entities
{
    /// <summary>
    /// Подъезд
    /// </summary>
    public class Enterance : IEntity<int>, IOrderedEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// ИД общежития
        /// </summary>
        public int HostelId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Номер по порядку
        /// </summary>
        public int? OrderNumber { get; set; }

        /// <summary>
        /// Общежите <see cref="Entities.Hostel"/>
        /// </summary>
        public virtual Hostel? Hostel { get; set; }
    }
}
