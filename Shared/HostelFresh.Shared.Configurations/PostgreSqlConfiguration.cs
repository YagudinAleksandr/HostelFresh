namespace HostelFresh.Shared.Configurations
{
    /// <summary>
    /// Конфигурация PostgreSQL
    /// </summary>
    public class PostgreSqlConfiguration
    {
        /// <summary>
        /// Строка подключения
        /// </summary>
        public string ConnectionString { get; set; } = string.Empty;
    }
}
