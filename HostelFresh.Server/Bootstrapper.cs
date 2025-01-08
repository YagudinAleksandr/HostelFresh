using HostelFresh.Application.Abstractions.Factories;
using HostelFresh.Application.Abstractions.Services;
using HostelFresh.Application.Database.Services;
using HostelFresh.Infrastructure.Common.Context.Npg;
using HostelFresh.Infrastructure.Common.Context.Sql;
using HostelFresh.Infrastructure.Logging;
using HostelFresh.Shared.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HostelFresh.Server
{
    /// <summary>
    /// Настройка DI
    /// </summary>
    internal static class Bootstrapper
    {
        /// <summary>
        /// Подключение конфигураций
        /// </summary>
        /// <param name="services">Коллекция сервисов</param>
        /// <param name="configuration">Конфигурация</param>
        /// <returns>Коллекция сервисов</returns>
        public static IServiceCollection GetConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DatabaseContextConfiguration>(configuration.GetSection("ConnectionSettings"));
            services.Configure<RedisConfiguration>(configuration.GetSection("Redis"));

            return services;
        }

        /// <summary>
        /// Подключение контекстов баз данных
        /// </summary>
        /// <param name="services">Коллекция сервисов</param>
        /// <param name="configuration">Конфигурация</param>
        /// <returns>Коллекция сервисов</returns>
        public static IServiceCollection GetDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionSettings = configuration.GetSection("ConnectionSettings").Get<DatabaseContextConfiguration>();

            if (connectionSettings != null)
            {
                services.AddDbContext<CommonContextSql>(options
                    => options.UseSqlServer(connectionSettings.MSSQL.ConnectionString));

                services.AddDbContext<CommonContextNpg>(options
                    => options.UseNpgsql(connectionSettings.PostgreSQL.ConnectionString));
            }
            
            return services;
        }

        /// <summary>
        /// Подключение сервисов
        /// </summary>
        /// <param name="services">Коллекция сервисов</param>
        /// <returns>Коллекция сервисов</returns>
        public static IServiceCollection GetServices(this IServiceCollection services)
        {
            services.AddSingleton(typeof(ILoggingService<>), typeof(LoggingService<>));
            services.AddSingleton<IDbFactory, DbFactory>(sp =>
            {
                var settings = sp.GetRequiredService<IOptions<DatabaseContextConfiguration>>().Value;
                return new DbFactory(settings, sp);
            });
            services.AddSingleton<IRedisFactory, RedisFactory>();

            return services;
        }
    }
}
