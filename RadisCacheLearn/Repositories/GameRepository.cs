using Microsoft.EntityFrameworkCore;
using RadisCacheLearn.Data;
using RadisCacheLearn.Models;

namespace RadisCacheLearn.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _context;

        public GameRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<Game>> GetAllGamesAsync()
        {
            return _context.Games.ToListAsync();
        }
    }
}
