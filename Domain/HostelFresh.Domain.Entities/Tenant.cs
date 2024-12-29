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
        public string UserId { get; set; } = null!;

        /// <summary>
        /// Тип жильца <see cref="TenantTypes"/>
        /// </summary>
        public TenantTypes Type { get; set; }

        /// <summary>
        /// Идентификация
        /// </summary>
        public byte[] Identification { get; set; } = null!;
    }
}
