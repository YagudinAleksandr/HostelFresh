using HostelFresh.Domain.Entities;
using HostelFresh.Shared.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HostelFresh.Infrastructure.Common.Configurations
{
    /// <summary>
    /// Конфигурация статей расхода <see cref="RatePaymentTax"/>
    /// </summary>
    public class RatePaymentTaxConfiguration : IEntityTypeConfiguration<RatePaymentTax>
    {
        public void Configure(EntityTypeBuilder<RatePaymentTax> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(DatabaseConsts.MiddleTextLenght).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(DatabaseConsts.StandartTextLenght).IsRequired(false);
            builder.Property(x => x.Count).HasDefaultValue(0);
            builder.Property(x => x.MeasurementType).HasConversion<int>().HasDefaultValueSql("2");
            builder.HasOne(x => x.Rate).WithMany(x => x.RatePaymentTaxes).HasForeignKey(x => x.RateId);
        }
    }
}
