using RadisCacheLearn.Models;

namespace RadisCacheLearn.Repositories
{
    public interface IGameRepository
    {
        Task<List<Game>> GetAllGamesAsync();
    }
}
