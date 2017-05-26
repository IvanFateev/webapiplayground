using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace webapiplayground.Models
{
    public class HiScoreContext : DbContext
    {
        public HiScoreContext(DbContextOptions<HiScoreContext> options)
            : base(options) {}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Score>();

        }
        public DbSet<Score> score { get; set; }
    }

    public class Score
    {
        [Key]
        public string Player { get; set; }
        public int score { get; set; }
    }

}