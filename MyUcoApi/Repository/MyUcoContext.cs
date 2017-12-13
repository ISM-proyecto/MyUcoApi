using Microsoft.EntityFrameworkCore;
using MyUcoApi.Models;

namespace MyUcoApi.Repository
{
    public class MyUcoContext : DbContext
    {
        public MyUcoContext(DbContextOptions<MyUcoContext> options) : base(options)
        {
        }

        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Beacon> Beacons { get; set; }
        public DbSet<Trajectory> Trajectories { get; set; }
    }
}