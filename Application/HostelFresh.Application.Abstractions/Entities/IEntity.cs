namespace HostelFresh.Application.Abstractions.Entities
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    /// <typeparam name="TKey">Тип ключа</typeparam>
    public interface IEntity<TKey>
    {
        /// <summary>
        /// ИД
        /// </summary>
        TKey Id { get; set; }
    }
}
