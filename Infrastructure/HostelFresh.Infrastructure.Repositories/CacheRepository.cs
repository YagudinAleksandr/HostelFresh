using HostelFresh.Application.Abstractions.Entities;
using HostelFresh.Application.Abstractions.Factories;
using HostelFresh.Application.Abstractions.Repositories;
using StackExchange.Redis;
using System.Text.Json;

namespace HostelFresh.Infrastructure.Repositories
{
    /// <inheritdoc cref="ICacheRepository{TEntity, TKey}"/>
    public class CacheRepository<TEntity, TKey> : ICacheRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
    {
        #region CTOR
        /// <inheritdoc cref="IRedisFactory"/>
        private readonly IRedisFactory _redisFactory;

        /// <inheritdoc cref="IDatabase"/>
        private readonly IDatabase _database;

        public CacheRepository(IRedisFactory redisFactory)
        {
            _redisFactory = redisFactory;

            _database = _redisFactory.CreateConnection().GetDatabase();
        }
        #endregion

        public async Task<TKey> CreateEntity(TEntity entity)
        {
            var key = entity.Id!.ToString();
            var serializeString = JsonSerializer.Serialize(entity);

            await _database.StringSetAsync(key, serializeString);

            return entity.Id;
        }

        public async Task DeleteEntity(TEntity entity)
        {
            await _database.KeyDeleteAsync(entity.Id!.ToString());
        }

        public async Task<IReadOnlyCollection<TEntity>> GetAll(Func<TEntity, bool>? filter = null)
        {
            var server = _database.Multiplexer.GetServer(_database.Multiplexer.GetEndPoints().First());
            var keys = server.Keys(pattern: $"{nameof(TEntity)}*").ToArray();

            var values = new List<TEntity>();
            foreach (var key in keys)
            {
                var value = await _database.StringGetAsync(key);
                if (!value.IsNullOrEmpty)
                {
                    var deserializedValue = JsonSerializer.Deserialize<TEntity>(value!);
                    if (deserializedValue != null)
                    {
                        values.Add(deserializedValue);
                    }
                }
            }

            if(filter != null)
            {
                return values.Where(filter).ToList().AsReadOnly();
            }
            else
            {
                return values.AsReadOnly();
            }
        }

        public async Task<TEntity?> GetById(TKey key)
        {
            var value = await _database.StringGetAsync(key!.ToString());
            if (value.IsNullOrEmpty)
            {
                return default;
            }
            else
            {
                return JsonSerializer.Deserialize<TEntity>(value!);
            }
        }

        public async Task<TKey> UpdatedEntity(TEntity entity)
        {
            var serializedValue = JsonSerializer.Serialize(entity);

            await _database.StringSetAsync(entity.Id!.ToString(), serializedValue);

            return entity.Id;
        }
    }
}
