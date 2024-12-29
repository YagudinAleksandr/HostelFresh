using HostelFresh.Application.Abstractions.Entities;
using HostelFresh.Shared.Enums;

namespace HostelFresh.Domain.Entities
{
    /// <summary>
    /// Статья расхода по тарифу
    /// </summary>
    public class RatePaymentTax : IEntity<int>
    {
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Тип измерения
        /// </summary>
        public MeasurementTypes MeasurementType { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public double Count { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public double Tax { get; set; }
    }
}
