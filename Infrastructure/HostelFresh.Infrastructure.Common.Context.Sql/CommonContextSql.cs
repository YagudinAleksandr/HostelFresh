using HostelFresh.Application.Abstractions.Factories;
using HostelFresh.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HostelFresh.Infrastructure.Common.Context.Sql
{
    public class CommonContextSql : MainCommonContext, IDbContext
    {
        public CommonContextSql(DbContextOptions<CommonContextSql> options) : base(options)
        {
        }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : class => base.Set<TEntity>();

        public new async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Tenant>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            base.OnModelCreating(modelBuilder);
        }
    }
}
