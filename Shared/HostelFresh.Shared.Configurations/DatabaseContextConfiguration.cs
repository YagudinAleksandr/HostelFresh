namespace HostelFresh.Shared.Configurations
{
    /// <summary>
    /// Конфигурации подключения к БД
    /// </summary>
    public class DatabaseContextConfiguration
    {
        /// <summary>
        /// Тип базы данных
        /// </summary>
        public string DatabaseType { get; set; } = string.Empty;

        /// <summary>
        /// Конфигурация MS SQL Server <see cref="MsSqlConfiguration"/>
        /// </summary>
        public MsSqlConfiguration MSSQL { get; set; } = new MsSqlConfiguration();

        /// <summary>
        /// Конфигурация PostgreSQL Server <see cref="PostgreSqlConfiguration"/>
        /// </summary>
        public PostgreSqlConfiguration PostgreSQL { get; set; } = new PostgreSqlConfiguration();
    }
}
