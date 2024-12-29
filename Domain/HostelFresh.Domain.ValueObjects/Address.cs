namespace HostelFresh.Domain.ValueObjects
{
    /// <summary>
    /// Вспомогательная модель адреса
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый код
        /// </summary>
        public int? PostalCode { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string Country { get; set; } = null!;

        /// <summary>
        /// Регион
        /// </summary>
        public string? Region { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; } = null!;

        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; } = null!;

        /// <summary>
        /// Дом
        /// </summary>
        public string House { get; set; } = null!;

        /// <summary>
        /// Строение
        /// </summary>
        public string? Building { get; set; }

        /// <summary>
        /// Квартира
        /// </summary>
        public string? Apartment { get; set; }
    }
}
