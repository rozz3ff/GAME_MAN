using GAME_MAN.Models;
using Microsoft.EntityFrameworkCore;
namespace GAME_MAN.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Score> Scores { get; set; } // Таблица Score
    }
}
