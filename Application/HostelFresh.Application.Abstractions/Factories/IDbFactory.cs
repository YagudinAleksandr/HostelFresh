namespace HostelFresh.Application.Abstractions.Factories
{
    /// <summary>
    /// Фабрика подключения к реляционным базам данных
    /// </summary>
    public interface IDbFactory
    {
        /// <summary>
        /// Создание контекста
        /// </summary>
        /// <returns>Контекст подключения</returns>
        IDbContext CreateDbScontext();
    }
}
