using HostelFresh.Domain.Entities;
using HostelFresh.Shared.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HostelFresh.Infrastructure.Common.Configurations
{
    /// <summary>
    /// Конфигурация жильца <see cref="Tenant"/>
    /// </summary>
    internal class TenantConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Type).HasDefaultValue(1);
            builder.Property(x => x.Identification).HasDefaultValue(DatabaseConsts.LongTextLenght).IsRequired();
            builder.Property(x => x.Address).HasDefaultValue(DatabaseConsts.LongTextLenght).IsRequired();
            builder.HasOne(t => t.User)
                   .WithOne(u => u.Tenant)
                   .HasForeignKey<Tenant>(t => t.UserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
