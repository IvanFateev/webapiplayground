using Microsoft.EntityFrameworkCore;

namespace webapiplayground.Models
{
    public class HiScoreContext : DbContext
    {
        HiScoreContext(DbContextOptions<HiScoreContext> options)
            : base(options) {}

        public DbSet<Score> score;
    }

    public class Score
    {
        public string Player { get; set; }
        public int score { get; set; }
    }

}