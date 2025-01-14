using System.ComponentModel.DataAnnotations;

namespace RadisCacheLearn.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public DateOnly ReleasedYear { get; set; }
        public string Publisher { get; set; }
        public decimal GamePrice { get; set; }
    }
}
