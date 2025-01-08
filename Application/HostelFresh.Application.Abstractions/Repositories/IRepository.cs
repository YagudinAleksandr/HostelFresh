using HostelFresh.Application.Abstractions.Entities;

namespace HostelFresh.Application.Abstractions.Repositories
{
    /// <summary>
    /// Репозиторий сущночтей
    /// </summary>
    /// <typeparam name="TEntity">Сущность</typeparam>
    /// <typeparam name="TKey">Тип ИД</typeparam>
    public interface IRepository<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        /// <summary>
        /// Создание сущности
        /// </summary>
        /// <param name="entity">Сущность</param>
        /// <returns>ИД</returns>
        Task<TKey> CreateEntity(TEntity entity);

        /// <summary>
        /// Обновление сущности
        /// </summary>
        /// <param name="entity">Сущность</param>
        /// <returns>ИД</returns>
        Task<TKey> UpdatedEntity(TEntity entity);

        /// <summary>
        /// Удаление сущности
        /// </summary>
        /// <param name="entity">Сущность</param>
        Task DeleteEntity(TEntity entity);

        /// <summary>
        /// Получение сущности по ИД
        /// </summary>
        /// <param name="key">ИД</param>
        /// <returns>Сущность</returns>
        Task<TEntity?> GetById(TKey key);

        /// <summary>
        /// Получение списка сущностей
        /// </summary>
        /// <param name="filter">Фильтр</param>
        /// <returns>Список сущностей</returns>
        IReadOnlyCollection<TEntity> GetAll(Func<TEntity, bool>? filter = null);
    }
}
