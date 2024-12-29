using HostelFresh.Shared.Enums;

namespace HostelFresh.Domain.ValueObjects
{
    /// <summary>
    /// Идентификационные данные
    /// </summary>
    public class Identification
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Отчество
        /// </summary>
        public string? MiddleName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Гражданство
        /// </summary>
        public string? Citizenship { get; set; }

        /// <summary>
        /// Тип документа удостоверяющего личность
        /// </summary>
        public IdentificationDocumentTypes IdentificationDocumentType { get; set; }

        /// <summary>
        /// Кем выдан документ
        /// </summary>
        public string IdentificationDocumentGiven { get; set; } = null!;

        /// <summary>
        /// Код подразделения
        /// </summary>
        public string IdentificationDocumentGivenCode { get; set; } = null!;

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateTime IdentificationDocumentGivenDate { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime? IdentificationDocumentEndDate { get; set; }

        /// <summary>
        /// Серия
        /// </summary>
        public string IdentificationDocumentSeries { get; set; } = null!;

        /// <summary>
        /// Номер
        /// </summary>
        public string IdentificationDocumentNumber { get; set; } = null!;
    }
}
