using Microsoft.EntityFrameworkCore;
using ServiceMate.Models.Domain;

namespace ServiceMate.Data {
    
    public class ServiceDbContext: DbContext {
        public ServiceDbContext(DbContextOptions dbContextOptions): base(dbContextOptions) {

        }

        public DbSet<ScheduledMaintenance> ScheduledMaintenances { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles  { get; set; }
    }
}