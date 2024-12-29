using HostelFresh.Domain.Entities;
using HostelFresh.Shared.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HostelFresh.Infrastructure.Common.Configurations
{
    /// <summary>
    /// Конфигурация общежития
    /// </summary>
    internal class HostelConfiguration : IEntityTypeConfiguration<Hostel>
    {
        public void Configure(EntityTypeBuilder<Hostel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(DatabaseConsts.ShortTextLenght).IsRequired();
        }
    }
}
