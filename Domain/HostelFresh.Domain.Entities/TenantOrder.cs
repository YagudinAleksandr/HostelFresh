using HostelFresh.Application.Abstractions.Entities;

namespace HostelFresh.Domain.Entities
{
    /// <summary>
    /// Договор найма
    /// </summary>
    public class TenantOrder : IEntity<DateTimeOffset>
    {
        public DateTimeOffset Id { get; set; }

        /// <summary>
        /// ИД жильца
        /// </summary>
        public Guid TenantId { get; set; }

        /// <summary>
        /// ИД комнаты
        /// </summary>
        public int RoomId { get; set; }

        /// <summary>
        /// ИД тарифного плана
        /// </summary>
        public int RateId { get; set; }

        /// <summary>
        /// Номер договора
        /// </summary>
        public string OrderName { get; set; } = null!;

        /// <summary>
        /// Дата начала договора
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата окончания договора
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Статус активности
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Жилец <see cref="Entities.Tenant"/>
        /// </summary>
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Комната <see cref="Entities.Room"/>
        /// </summary>
        public virtual Room? Room { get; set; }

        /// <summary>
        /// Тарифный план <see cref="Entities.Rate"/>
        /// </summary>
        public virtual Rate? Rate { get; set; }
    }
}
