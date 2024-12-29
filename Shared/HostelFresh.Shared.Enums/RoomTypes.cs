using System.ComponentModel.DataAnnotations;

namespace HostelFresh.Shared.Enums
{
    /// <summary>
    /// Типы комнат
    /// </summary>
    public enum RoomTypes
    {
        /// <summary>
        /// Стандартная
        /// </summary>
        [Display(Name = "Стандарт")]
        Standart = 1,

        /// <summary>
        /// Комфорт
        /// </summary>
        [Display(Name = "Комфорт")]
        Comfort = 2,

        /// <summary>
        /// Комфорт +
        /// </summary>
        [Display(Name = "Комфорт +")]
        ComfortPlus = 3,

        /// <summary>
        /// Улучшенный
        /// </summary>
        [Display(Name = "Улучшенный")]
        Improved = 4
    }
}
