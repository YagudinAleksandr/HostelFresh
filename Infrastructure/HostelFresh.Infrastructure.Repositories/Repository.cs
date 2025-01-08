using HostelFresh.Application.Abstractions.Entities;
using HostelFresh.Application.Abstractions.Factories;
using HostelFresh.Application.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HostelFresh.Infrastructure.Repositories
{
    /// <inheritdoc cref="IRepository{TEntity, TKey}"/>
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> 
        where TEntity : class, IEntity<TKey>, new() 
        where TKey : notnull
    {
        #region CTOR
        /// <inheritdoc cref="IDbFactory"/>
        private readonly IDbFactory _dbFactory;

        /// <inheritdoc cref="DbSet{TEntity}"/>
        private readonly DbSet<TEntity> _dbSet;

        /// <inheritdoc cref="IDbContext"/>
        private readonly IDbContext _context;

        public Repository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
            _context = _dbFactory.CreateDbScontext();
            _dbSet = _context.Set<TEntity>();
        }
        #endregion

        public async Task<TKey> CreateEntity(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task DeleteEntity(TEntity entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyCollection<TEntity> GetAll(Func<TEntity, bool>? filter = null)
        {
            return filter == null ? _dbSet.ToList() : _dbSet.Where(filter).ToList();
        }

        public async Task<TEntity?> GetById(TKey key)
        {
            return await _dbSet.FindAsync(key);
        }

        public async Task<TKey> UpdatedEntity(TEntity entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
    }
}
