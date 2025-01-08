using HostelFresh.Application.Abstractions.Entities;

namespace HostelFresh.Domain.Entities
{
    /// <summary>
    /// Тарифный план
    /// </summary>
    public class Rate : IEntity<int>
    {
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// ИД общежития
        /// </summary>
        public int HostelId { get; set; }

        /// <summary>
        /// Общежитие <see cref="Entities.Hostel"/>
        /// </summary>
        public virtual Hostel? Hostel { get; set; }

        /// <summary>
        /// Статьи расхода <see cref="RatePaymentTax"/>
        /// </summary>
        public IReadOnlyCollection<RatePaymentTax>? RatePaymentTaxes { get; set; }
    }
}
