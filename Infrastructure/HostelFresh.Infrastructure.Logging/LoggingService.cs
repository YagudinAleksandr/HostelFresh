using HostelFresh.Application.Abstractions.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;

namespace HostelFresh.Infrastructure.Logging
{
    /// <inheritdoc cref="ILoggingService{T}"/>
    public class LoggingService<T> : ILoggingService<T> where T : class
    {
        #region CTOR
        /// <inheritdoc cref="ILogger"/>
        private readonly ILogger<T> _logger;

        public LoggingService(IConfiguration configuration, ILogger<T> logger)
        {
            if(!string.IsNullOrEmpty(configuration["Serilog:Seq:ServerUrl"]))
            {
                Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .WriteTo.Seq(configuration["Serilog:Seq:ServerUrl"]!)
                .CreateLogger();
            }

            _logger = logger;
        }
        #endregion

        public void LogError(string message, Exception exception)
        {
            _logger.LogError(exception, message);
        }

        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
            
        }

        public void LogWarning(string message)
        {
            _logger.LogWarning(message);
        }
    }
}
