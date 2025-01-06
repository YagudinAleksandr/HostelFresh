using HostelFresh.Domain.Entities;
using HostelFresh.Shared.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HostelFresh.Infrastructure.Common.Configurations
{
    /// <summary>
    /// конфигурация лицензий <see cref="License"/>
    /// </summary>
    public class LicenseConfiguration : IEntityTypeConfiguration<License>
    {
        public void Configure(EntityTypeBuilder<License> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(DatabaseConsts.MiddleTextLenght).IsRequired();
            builder.Property(x => x.Type).HasConversion<int>().HasDefaultValueSql("1");
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.HasOne(x => x.Hostel).WithMany(x => x.Licenses).HasForeignKey(x => x.HostelId);
            builder.HasOne(x => x.User).WithMany(x => x.Licenses).HasForeignKey(x => x.UserId);
        }
    }
}
