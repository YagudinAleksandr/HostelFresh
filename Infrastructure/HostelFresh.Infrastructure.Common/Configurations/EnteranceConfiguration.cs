using HostelFresh.Domain.Entities;
using HostelFresh.Shared.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HostelFresh.Infrastructure.Common.Configurations
{
    /// <summary>
    /// Конфигурация подъезда <see cref="Enterance"/>
    /// </summary>
    public class EnteranceConfiguration : IEntityTypeConfiguration<Enterance>
    {
        public void Configure(EntityTypeBuilder<Enterance> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(DatabaseConsts.ShortTextLenght);
            builder.HasOne(x => x.Hostel).WithMany(e => e.Enterances).HasForeignKey(x => x.HostelId);
        }
    }
}
