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
        /// Подъезды <see cref="Enterance"/>
        /// </summary>
        public virtual IReadOnlyCollection<Enterance>? Enterances { get; set; }

        /// <summary>
        /// Тарифные планы <see cref="Rate"/>
        /// </summary>
        public virtual IReadOnlyCollection<Rate>? Rates { get; set; }

        /// <summary>
        /// Лицензии <see cref="License"/>
        /// </summary>
        public virtual IReadOnlyCollection<License>? Licenses { get; set; }
    }
}
