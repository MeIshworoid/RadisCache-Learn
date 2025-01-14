using Microsoft.EntityFrameworkCore;
using RadisCacheLearn.Models;

namespace RadisCacheLearn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
       
    }
}
