using HostelFresh.Application.Abstractions.Entities;

namespace HostelFresh.Domain.Entities
{
    /// <summary>
    /// Общежитие
    /// </summary>
    public class Hostel : IEntity<int>, IOrderedEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; } = null!;

        /// <summary>
        /// Номер по порядку
        /// </summary>
        public int? OrderNumber { get; set; }

        /// <summary>
        /// Подъезды
        /// </summary>
        public virtual IReadOnlyCollection<Enterance> Enterances { get; set; } = new List<Enterance>();

        /// <summary>
        /// Тарифные планы
        /// </summary>
        public virtual IReadOnlyCollection<Rate> Rates { get; set; } = new List<Rate>();
    }
}
