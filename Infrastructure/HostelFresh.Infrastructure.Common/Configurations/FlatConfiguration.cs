using HostelFresh.Domain.Entities;
using HostelFresh.Shared.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HostelFresh.Infrastructure.Common.Configurations
{
    /// <summary>
    /// Конфигурация этажа <see cref="Flat"/>
    /// </summary>
    public class FlatConfiguration : IEntityTypeConfiguration<Flat>
    {
        public void Configure(EntityTypeBuilder<Flat> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(DatabaseConsts.ShortTextLenght).IsRequired();
            builder.HasOne(e => e.Enterance).WithMany(f => f.Flats).HasForeignKey(x => x.EnteranceId);
        }
    }
}
