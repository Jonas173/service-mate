using Microsoft.EntityFrameworkCore;
using ServiceMate.API.Models.Domain;

namespace ServiceMate.API.Data {
    
    public class ServiceDbContext: DbContext {
        public ServiceDbContext(DbContextOptions dbContextOptions): base(dbContextOptions) {

        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Vehicle> Vehicles  { get; set; }
    }
}