namespace HostelFresh.Shared.Configurations
{
    /// <summary>
    /// Конфигурация Redis
    /// </summary>
    public class RedisConfiguration
    {
        /// <summary>
        /// Строка подключения
        /// </summary>
        public string ConnectionString { get; set; } = string.Empty;
    }
}
