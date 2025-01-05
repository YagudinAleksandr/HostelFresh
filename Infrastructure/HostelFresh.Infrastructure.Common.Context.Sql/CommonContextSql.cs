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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Tenant>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        }
    }
}
