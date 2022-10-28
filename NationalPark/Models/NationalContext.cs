using Microsoft.EntityFrameworkCore;

namespace National.Models{
    public class NationalContext : DbContext
    {
        public NationalContext(DbContextOptions<NationalContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Park>()
            .HasData(
                new Park { ParkId = 1, Name = "Yellowstone", State = "Wyoming", Camping = "Yes" }
            );
        builder.Entity<Activity>()
            .HasData(
                new Activity { ActivityId = 1, Name = "Hiking", Type = "Outdoors", Size = 10, ParkId = 1}
            );
        }
        public DbSet<Park> Parks { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}