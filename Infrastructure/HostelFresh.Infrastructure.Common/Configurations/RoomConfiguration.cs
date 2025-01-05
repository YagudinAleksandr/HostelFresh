using HostelFresh.Domain.Entities;
using HostelFresh.Shared.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HostelFresh.Infrastructure.Common.Configurations
{
    /// <summary>
    /// Конфигурация комнаты <see cref="Room"/>
    /// </summary>
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(DatabaseConsts.ShortTextLenght).IsRequired();
            builder.HasOne(x => x.Flat).WithMany(x => x.Rooms).HasForeignKey(x => x.FlatId);
            builder.Property(x => x.Type).HasConversion<int>().HasDefaultValueSql("1");
        }
    }
}
