using DomainLayer.Contracts;
using ServiceAbstracion;
using System.Text.Json;

namespace Service
{
    public class CacheService(ICacheRepository cacheRepository) : ICacheService
    {
        private static readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public async Task<string?> GetAsync(string cacheKey)
            => await cacheRepository.GetAsync(cacheKey);

        public async Task SetAsync(string cacheKey, object cacheValue, TimeSpan timeToLive)
        {
            if (cacheValue is null) return;
            var serialized = JsonSerializer.Serialize(cacheValue, _jsonOptions); 
            await cacheRepository.SetAsync(cacheKey, serialized, timeToLive);
        }

        public async Task RemoveByPrefixAsync(string keyPrefix)
            => await cacheRepository.RemoveByPrefixAsync(keyPrefix);
    }
}