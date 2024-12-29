using System.ComponentModel.DataAnnotations;

namespace HostelFresh.Shared.Enums
{
    /// <summary>
    /// Типы лицензий
    /// </summary>
    public enum LicenseTypes
    {
        /// <summary>
        /// Лицензия
        /// </summary>
        [Display(Name = "Лицензия")]
        License = 1,

        /// <summary>
        /// Доверенность
        /// </summary>
        [Display(Name = "Доверенность")]
        Attorney = 2
    }
}
