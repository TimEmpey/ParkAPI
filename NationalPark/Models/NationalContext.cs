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
                new Park { ParkId = 1, Name = "Yellowstone", State = "Wyoming", Camping = "Yes" },
                new Park { ParkId = 2, Name = "Grand Canyon", State = "Arizona", Camping = "No" },
                new Park { ParkId = 3, Name = "Yosemite", State = "California", Camping = "Yes" },
                new Park { ParkId = 4, Name = "Zion", State = "Virginia", Camping = "No" },
                new Park { ParkId = 5, Name = "Rocky Mountain", State = "Colorado", Camping = "Yes" },
                new Park { ParkId = 6, Name = "Glacier", State = "Montana", Camping = "Yes" }
            );
        builder.Entity<Activity>()
            .HasData(
                new Activity { ActivityId = 1, Name = "Hiking", Type = "Outdoors", Size = 10, ParkId = 1},
                new Activity { ActivityId = 2, Name = "Climbing", Type = "Outdoors", Size = 3, ParkId = 1},
                new Activity { ActivityId = 3, Name = "Tour", Type = "Outdoors", Size = 30, ParkId = 2},
                new Activity { ActivityId = 5, Name = "Hiking", Type = "Outdoors", Size = 10, ParkId = 3},
                new Activity { ActivityId = 6, Name = "Camping", Type = "Outdoors", Size = 6, ParkId = 3},
                new Activity { ActivityId = 7, Name = "Hiking", Type = "Outdoors", Size = 10, ParkId = 4},
                new Activity { ActivityId = 8, Name = "Hiking", Type = "Outdoors", Size = 10, ParkId = 4},
                new Activity { ActivityId = 9, Name = "Hiking", Type = "Outdoors", Size = 10, ParkId = 5},
                new Activity { ActivityId = 10, Name = "Hiking", Type = "Outdoors", Size = 10, ParkId = 5},
                new Activity { ActivityId = 11, Name = "Hiking", Type = "Outdoors", Size = 10, ParkId = 6},
                new Activity { ActivityId = 12, Name = "Hiking", Type = "Outdoors", Size = 10, ParkId = 6}
            );
        }
        public DbSet<Park> Parks { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}