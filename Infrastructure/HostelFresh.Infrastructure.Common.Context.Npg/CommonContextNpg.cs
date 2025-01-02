using HostelFresh.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HostelFresh.Infrastructure.Common.Context.Npg
{
    public class CommonContextNpg : MainCommonContext
    {
        public CommonContextNpg(DbContextOptions<CommonContextNpg> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");
            modelBuilder.Entity<Tenant>().Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");
        }
    }
}
