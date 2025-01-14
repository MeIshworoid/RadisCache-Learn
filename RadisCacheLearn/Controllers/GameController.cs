using Microsoft.AspNetCore.Mvc;
using RadisCacheLearn.Models;
using RadisCacheLearn.Service;

namespace RadisCacheLearn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Game>>> GetGames()
        {
            var games = await _gameService.GetAllGamesAsync();
            return Ok(games);
        }
    }
}
