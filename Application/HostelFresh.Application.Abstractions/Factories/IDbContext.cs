using Microsoft.EntityFrameworkCore;

namespace HostelFresh.Application.Abstractions.Factories
{
    /// <summary>
    /// Интерфейс подключения к БД
    /// </summary>
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
