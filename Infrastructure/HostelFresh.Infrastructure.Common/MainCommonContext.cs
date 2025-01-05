using HostelFresh.Infrastructure.Common.Configurations;
using Microsoft.EntityFrameworkCore;

namespace HostelFresh.Infrastructure.Common
{
    /// <summary>
    /// Базовый контекст подключения к БД
    /// </summary>
    public abstract class MainCommonContext : DbContext
    {
        public MainCommonContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HostelConfiguration).Assembly);
        }
    }
}
