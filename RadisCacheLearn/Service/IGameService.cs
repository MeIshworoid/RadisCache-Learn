using RadisCacheLearn.Models;

namespace RadisCacheLearn.Service
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGamesAsync();
    }
}
