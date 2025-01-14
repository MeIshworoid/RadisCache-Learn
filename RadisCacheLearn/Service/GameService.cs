using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using RadisCacheLearn.Models;
using RadisCacheLearn.Repositories;
using System.Text.Json;

namespace RadisCacheLearn.Service
{
    public class GameService : IGameService
    {
        private readonly IDistributedCache _distributedCacheService;
        private readonly IGameRepository _gameRepository;

        public GameService(IDistributedCache distributedCacheService, IGameRepository gameRepository)
        {
            _distributedCacheService = distributedCacheService;
            _gameRepository = gameRepository;
        }

        public async Task<List<Game>> GetAllGamesAsync()
        {
            // first check key has cached games or not

            string? cachedGames = await _distributedCacheService.GetStringAsync("games");
            if (!string.IsNullOrWhiteSpace(cachedGames))
            {
                return JsonConvert.DeserializeObject<List<Game>>(cachedGames);
            }

            var games = await _gameRepository.GetAllGamesAsync();

            // Cache the list of games if not already cached, time set to 5 minutes
            var serializedGames = JsonConvert.SerializeObject(games);
            await _distributedCacheService.SetStringAsync("games", serializedGames, new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            });

            return games;
        }
    }
}
