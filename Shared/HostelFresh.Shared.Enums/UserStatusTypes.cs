using System.ComponentModel.DataAnnotations;

namespace HostelFresh.Shared.Enums
{
    /// <summary>
    /// Статусы активности пользователя
    /// </summary>
    public enum UserStatusTypes
    {
        /// <summary>
        /// Активен
        /// </summary>
        [Display(Name = "Активен")]
        Active = 1,

        /// <summary>
        /// Заблокирован
        /// </summary>
        [Display(Name = "Заблокирован")]
        Blocked = 2,

        /// <summary>
        /// Не активен
        /// </summary>
        [Display(Name = "Не активен")]
        NotActive = 3
    }
}
