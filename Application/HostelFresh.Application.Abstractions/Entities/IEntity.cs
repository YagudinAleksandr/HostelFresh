namespace HostelFresh.Application.Abstractions.Entities
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    /// <typeparam name="T">Тип ИД</typeparam>
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
