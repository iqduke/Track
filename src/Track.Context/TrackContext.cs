using Microsoft.EntityFrameworkCore;
using Track.Models;

namespace Track.Context
{
    public class TrackContext : DbContext
    {
        public TrackContext(DbContextOptions<TrackContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TrackConfig> TrackConfigs { get; set; }
        public DbSet<TrackMain> TrackMains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;database=ef;uid=root;pwd=1qaz@WSX");
        }
    }
}
