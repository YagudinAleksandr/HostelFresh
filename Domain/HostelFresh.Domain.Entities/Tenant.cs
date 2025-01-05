using HostelFresh.Application.Abstractions.Entities;
using HostelFresh.Shared.Enums;

namespace HostelFresh.Domain.Entities
{
    /// <summary>
    /// Жилец
    /// </summary>
    public class Tenant : IEntity<Guid>
    {
        public Guid Id { get; set; }

        /// <summary>
        /// ИД пользователя
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Тип жильца <see cref="TenantTypes"/>
        /// </summary>
        public TenantTypes Type { get; set; }

        /// <summary>
        /// Идентификация
        /// </summary>
        public string Identification { get; set; } = null!;

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; } = null!;

        /// <summary>
        /// Пользователь <see cref="Entities.User"/>
        /// </summary>
        public virtual User? User { get; set; }
    }
}
