using HostelFresh.Domain.Entities;
using HostelFresh.Shared.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HostelFresh.Infrastructure.Common.Configurations
{
    /// <summary>
    /// Конфигурация комнаты
    /// </summary>
    internal class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(DatabaseConsts.ShortTextLenght).IsRequired();
            builder.Property(x => x.Type).HasDefaultValue(1).IsRequired();
            builder.Property(x => x.MaxTenant).HasDefaultValue(2);
            builder.HasOne(x => x.Flat).WithMany(x => x.Rooms).HasForeignKey(x => x.FlatId);
        }
    }
}
