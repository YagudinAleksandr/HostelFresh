namespace HostelFresh.Application.Abstractions.Entities
{
    /// <summary>
    /// Упорядоченная сущность
    /// </summary>
    public interface IOrderedEntity
    {
        /// <summary>
        /// Порядковый номер
        /// </summary>
        int? OrderNumber { get; set; }
    }
}
