using HostelFresh.Application.Abstractions.Entities;

namespace HostelFresh.Application.Abstractions.Repositories
{
    /// <summary>
    /// Репозиторий данных кэша Redis
    /// </summary>
    /// <typeparam name="TEntity">Сущность</typeparam>
    /// <typeparam name="TKey">Тип ИД</typeparam>
    public interface ICacheRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
    {
    }
}
