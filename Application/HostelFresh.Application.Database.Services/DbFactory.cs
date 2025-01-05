using HostelFresh.Application.Abstractions.Factories;
using HostelFresh.Infrastructure.Common.Context.Npg;
using HostelFresh.Infrastructure.Common.Context.Sql;
using HostelFresh.Shared.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace HostelFresh.Application.Database.Services
{
    /// <summary>
    /// <inheritdoc cref="IDbFactory"/>
    /// </summary>
    public class DbFactory : IDbFactory
    {
        #region CTOR
        /// <inheritdoc cref="DatabaseContextConfiguration"/>
        private readonly DatabaseContextConfiguration _contextConfiguration;

        /// <inheritdoc cref="IServiceProvider"/>
        private readonly IServiceProvider _serviceProvider;

        public DbFactory(DatabaseContextConfiguration contextConfiguration, IServiceProvider serviceProvider)
        {
            _contextConfiguration = contextConfiguration;
            _serviceProvider = serviceProvider;
        }
        #endregion

        public IDbContext CreateDbScontext()
        {
            return _contextConfiguration.DatabaseType switch
            {
                "MSSQL" => _serviceProvider.GetRequiredService<CommonContextSql>(),
                "PostgreSQL" => _serviceProvider.GetRequiredService<CommonContextNpg>(),
                _ => throw new InvalidOperationException("Unsupported database type")
            };
        }
    }
}
