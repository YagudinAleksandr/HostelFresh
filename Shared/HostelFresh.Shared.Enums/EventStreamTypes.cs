using System.ComponentModel.DataAnnotations;

namespace HostelFresh.Shared.Enums
{
    /// <summary>
    /// Типы потоков EventStore
    /// </summary>
    public enum EventStreamTypes
    {
        /// <summary>
        /// Не указан
        /// </summary>
        [Display(Name = "Не указан")]
        None = 0,

        /// <summary>
        /// Общежитие
        /// </summary>
        [Display(Name = "Общежитие")]
        Hostel = 1,

        /// <summary>
        /// Пользователь
        /// </summary>
        [Display(Name = "Пользователь")]
        User = 2,

        /// <summary>
        /// Жилец
        /// </summary>
        [Display (Name = "Жилец")]
        Tenant = 3,

        /// <summary>
        /// Тарифный план
        /// </summary>
        [Display(Name = "Тарифные планы")]
        Rate = 4
    }
}
