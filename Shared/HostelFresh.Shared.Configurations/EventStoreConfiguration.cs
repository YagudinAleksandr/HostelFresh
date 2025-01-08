namespace HostelFresh.Shared.Configurations
{
    /// <summary>
    /// Конфигурация EventStore
    /// </summary>
    public class EventStoreConfiguration
    {
        /// <summary>
        /// Строка подключения
        /// </summary>
        public string ConnectionString { get; set; } = string.Empty;
    }
}
