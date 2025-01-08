using HostelFresh.Application.Abstractions.Factories;
using HostelFresh.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HostelFresh.Infrastructure.Common.Context.Npg
{
    public class CommonContextNpg : MainCommonContext, IDbContext
    {
        public CommonContextNpg(DbContextOptions<CommonContextNpg> options) : base(options)
        {
        }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : class => base.Set<TEntity>();

        public new async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");
            modelBuilder.Entity<Tenant>().Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");

            base.OnModelCreating(modelBuilder);
        }
    }
}
