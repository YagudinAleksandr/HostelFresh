using HostelFresh.Shared.Enums;
using Microsoft.AspNetCore.Identity;

namespace HostelFresh.Domain.Entities
{
    /// <summary>
    /// Пользователь приложения
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// ФИО пользователя
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Тип пользователя <see cref="UserTypes"/>
        /// </summary>
        public UserTypes Type { get; set; }

        /// <summary>
        /// Статус активности пользователя (True - активен, False - не активен)
        /// </summary>
        public bool IsActive { get; set; }
    }
}
