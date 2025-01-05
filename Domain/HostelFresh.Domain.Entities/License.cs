using HostelFresh.Application.Abstractions.Entities;
using HostelFresh.Shared.Enums;

namespace HostelFresh.Domain.Entities
{
    /// <summary>
    /// Лицензия
    /// </summary>
    public class License : IEntity<Guid>
    {
        public Guid Id { get; set; }

        /// <summary>
        /// ИД пользователя
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// ИД общежития
        /// </summary>
        public int HostelId { get; set; }

        /// <summary>
        /// Название документа
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Тип <see cref="LicenseTypes"/>
        /// </summary>
        public LicenseTypes Type { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Статус активности
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Пользователь <see cref="Entities.User"/>
        /// </summary>
        public virtual User? User { get; set; }

        /// <summary>
        /// Общежитие <see cref="Entities.Hostel"/>
        /// </summary>
        public virtual Hostel? Hostel { get; set; }
    }
}
