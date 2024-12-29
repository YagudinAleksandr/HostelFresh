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
        public byte[] Address { get; set; } = null!;

        /// <summary>
        /// Номер по порядку
        /// </summary>
        public int? OrderNumber { get; set; }
    }
}
