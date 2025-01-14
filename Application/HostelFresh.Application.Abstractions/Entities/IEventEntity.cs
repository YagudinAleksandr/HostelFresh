namespace HostelFresh.Application.Abstractions.Entities
{
    /// <summary>
    /// Интерфейс события
    /// </summary>
    public interface IEventEntity
    {
        /// <summary>
        /// ИД сущности события
        /// </summary>
        string Id { get; set; }
    }
}
