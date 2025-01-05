using HostelFresh.Domain.Entities;
using HostelFresh.Shared.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HostelFresh.Infrastructure.Common.Configurations
{
    /// <summary>
    /// Конфигруация пользователя <see cref="User"/>
    /// </summary>
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(DatabaseConsts.MiddleTextLenght).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(DatabaseConsts.StandartTextLenght).IsRequired(false);
            builder.Property(x => x.Email).HasMaxLength(DatabaseConsts.MiddleTextLenght).IsRequired();
            builder.Property(x => x.Type).HasConversion<int>().HasDefaultValueSql("2");
            builder.Property(x => x.Status).HasDefaultValueSql("1");
            builder.Property(x => x.FailedLoginAttempts).HasDefaultValue(0);
            builder.Property(x => x.NormilizedUsername).HasMaxLength(DatabaseConsts.StandartTextLenght).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(DatabaseConsts.ShortTextLenght).IsRequired(false);
            builder.HasOne(u => u.Tenant) // Связываем User с Tenant
                   .WithOne(t => t.User) // Обратная связь
                   .HasForeignKey<Tenant>(t => t.UserId) // Внешний ключ в Tenant
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
