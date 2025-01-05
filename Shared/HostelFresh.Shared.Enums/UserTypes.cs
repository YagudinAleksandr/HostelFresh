using System.ComponentModel.DataAnnotations;

namespace HostelFresh.Shared.Enums
{
    /// <summary>
    /// Типы пользователей
    /// </summary>
    public enum UserTypes
    {
        /// <summary>
        /// Система
        /// </summary>
        [Display(Name = "СИСТЕМА")]
        System = 1,

        /// <summary>
        /// Пользователь
        /// </summary>
        [Display(Name = "Пользователь")]
        User = 2,

        /// <summary>
        /// Менеджер
        /// </summary>
        [Display(Name = "Менеджер")]
        Manager = 3,

        /// <summary>
        /// Администратор
        /// </summary>
        [Display(Name = "Администратор")]
        Administrator = 4
    }
}
