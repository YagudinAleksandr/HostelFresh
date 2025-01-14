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

        /// <inheritdoc cref="ICacheRepository{TEntity, TKey}"/>
        private readonly ICacheRepository<TEntity, TKey> _cacheRepository;


        public Repository(IDbFactory dbFactory, ICacheRepository<TEntity, TKey> cacheRepository)
        {
            _dbFactory = dbFactory;
            _context = _dbFactory.CreateDbScontext();
            _dbSet = _context.Set<TEntity>();
            _cacheRepository = cacheRepository;
        }
        #endregion

        public async Task<TKey> CreateEntity(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            if(entity is ICacheEntity)
            {
                await _cacheRepository.CreateEntity(entity);
            }

            return entity.Id;
        }

        public async Task DeleteEntity(TEntity entity)
        {
            _dbSet.Remove(entity);

            if(entity is ICacheEntity)
            {
                await _cacheRepository.DeleteEntity(entity);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<TEntity>> GetAll(Func<TEntity, bool>? filter = null)
        {
            if(typeof(TEntity) is ICacheEntity)
            {
                return await _cacheRepository.GetAll(filter);
            }

            var query = _dbSet.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter).AsQueryable();
            }

            var result = await query.ToListAsync();

            return result.AsReadOnly();
        }

        public async Task<TEntity?> GetById(TKey key)
        {
            TEntity? entity = null;

            if(typeof(TEntity) is ICacheEntity)
            {
                entity = await _cacheRepository.GetById(key);
            }

            if(entity == null)
            {
                return await _dbSet.FindAsync(key);
            }
            else
            {
                return entity;
            }
        }

        public async Task<TKey> UpdatedEntity(TEntity entity)
        {
            if(entity is ICacheEntity)
            {
                await _cacheRepository.UpdatedEntity(entity);
            }

            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
    }
}
