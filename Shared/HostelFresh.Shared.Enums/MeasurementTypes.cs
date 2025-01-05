using System.ComponentModel.DataAnnotations;

namespace HostelFresh.Shared.Enums
{
    /// <summary>
    /// Единицы измерения
    /// </summary>
    public enum MeasurementTypes
    {
        /// <summary>
        /// Метры
        /// </summary>
        [Display(Name = "Метры")]
        Meters = 1,

        /// <summary>
        /// Штуки
        /// </summary>
        [Display(Name = "Штуки")]
        Item = 2,

        /// <summary>
        /// Квадратные метры
        /// </summary>
        [Display(Name = "Квадратные метры")]
        SquareMeters = 3,

        /// <summary>
        /// Киловатт/час
        /// </summary>
        [Display(Name = "Киловат в час")]
        KilowattPerHour = 4,

        /// <summary>
        /// Метры кубические
        /// </summary>
        [Display(Name = "Метры кубические")]
        CoubeMeters = 5
    }
}
