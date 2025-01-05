using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace HostelFresh.Infrastructure.Logging
{
    /// <summary>
    /// Кастомная настройка логирования
    /// </summary>
    public static class LoggingConfiguration
    {
        /// <summary>
        /// Добавление логирования
        /// </summary>
        /// <param name="services">Коллекция сервисов</param>
        /// <param name="configuration">Настройки</param>
        public static void AddCustomLogging(this IServiceCollection services, IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration) 
                .CreateLogger();

            services.AddLogging(loggingBuilder =>
                loggingBuilder.AddSerilog(dispose: true));
        }
    }
}
