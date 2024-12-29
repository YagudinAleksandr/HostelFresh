using HostelFresh.Application.Abstractions.Entities;
using HostelFresh.Shared.Enums;

namespace HostelFresh.Domain.Entities
{
    public class Room : IEntity<int>, IOrderedEntity
    {
        public int Id { get; set; }

        public int? OrderNumber { get; set; }

        /// <summary>
        /// ИД этажа
        /// </summary>
        public int FlatId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Тип комнаты <see cref="RoomTypes"/>
        /// </summary>
        public RoomTypes Type { get; set; }

        /// <summary>
        /// Этаж <see cref="Entities.Flat"/>
        /// </summary>
        public virtual Flat? Flat { get; set; }
    }
}
