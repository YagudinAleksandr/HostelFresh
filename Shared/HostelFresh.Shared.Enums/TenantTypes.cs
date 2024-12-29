using System.ComponentModel.DataAnnotations;

namespace HostelFresh.Shared.Enums
{
    /// <summary>
    /// Типы жильцов
    /// </summary>
    public enum TenantTypes
    {
        /// <summary>
        /// Студент
        /// </summary>
        [Display(Name = "Студент")]
        Student = 1,

        /// <summary>
        /// Сотрудник
        /// </summary>
        [Display(Name = "Сотрудник")]
        Worker = 2,

        /// <summary>
        /// Другой
        /// </summary>
        [Display(Name = "Другой")]
        Other = 3
    }
}
