using System.ComponentModel.DataAnnotations;

namespace HostelFresh.Shared.Enums
{
    /// <summary>
    /// Типы документов удостоверяющих личность
    /// </summary>
    public enum IdentificationDocumentTypes
    {
        /// <summary>
        /// Паспорт
        /// </summary>
        [Display(Name = "Паспорт")]
        Passport = 1,

        /// <summary>
        /// Паспорт иностранного гражданина
        /// </summary>
        [Display(Name = "Паспорт иностранного гражданина")]
        ForeignPassport = 2,

        /// <summary>
        /// Паспорт лица без гражданства
        /// </summary>
        [Display(Name = "Паспорт лица без гражданства")]
        WithoutCitizenship = 3
    }
}
