using Microsoft.EntityFrameworkCore;
using Schedule.Models;

namespace Schedule.DATA
{
    public class SchedulingDbContext : DbContext
    {
        public SchedulingDbContext(DbContextOptions<SchedulingDbContext> options) : base(options) 
        {
        }

        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<ScheduleDayRoomTime> ScheduleDayRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
