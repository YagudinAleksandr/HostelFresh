using HostelFresh.Application.Abstractions.Entities;
using HostelFresh.Shared.Enums;

namespace HostelFresh.Domain.Entities
{
    /// <summary>
    /// Пользователь приложения
    /// </summary>
    public class User : IEntity<Guid>
    {
        public Guid Id { get; set; }

        /// <summary>
        /// ФИО пользователя
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; } = null!;

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get; set; } = null!;

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;

        /// <summary>
        /// Нормализованное имя пользователя в верхнем регистре
        /// </summary>
        public string NormilizedUsername {  get; set; } = null!;

        /// <summary>
        /// Количество неудачных попыток входа
        /// </summary>
        public int FailedLoginAttempts { get; set; }

        /// <summary>
        /// Тип пользователя <see cref="UserTypes"/>
        /// </summary>
        public UserTypes Type { get; set; }

        /// <summary>
        /// Статус активности пользователя
        /// </summary>
        public UserStatusTypes Status { get; set; }

        /// <summary>
        /// Жилец <see cref="Entities.Tenant"/>
        /// </summary>
        public virtual Tenant? Tenant { get; set; }

        /// <summary>
        /// Лицензии <see cref="License"/>
        /// </summary>
        public virtual IReadOnlyCollection<License>? Licenses { get; set; }
    }
}
