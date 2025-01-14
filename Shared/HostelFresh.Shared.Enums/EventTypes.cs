using System.ComponentModel.DataAnnotations;

namespace HostelFresh.Shared.Enums
{
    /// <summary>
    /// Типы событий
    /// </summary>
    public enum EventTypes
    {
        /// <summary>
        /// Глобальное событие
        /// </summary>
        [Display(Name = "Глобальное событие")]
        GlobalEvent = 0,

        /// <summary>
        /// Создание
        /// </summary>
        [Display(Name = "Создание")]
        Create = 1,

        /// <summary>
        /// Обновление
        /// </summary>
        [Display(Name = "Обновление")]
        Update = 2,

        /// <summary>
        /// Удаление
        /// </summary>
        [Display(Name = "Удаление")]
        Delete = 3
    }
}
