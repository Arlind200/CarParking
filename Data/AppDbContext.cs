using Microsoft.EntityFrameworkCore;
using CarParking.Models.Entities;

namespace CarParking.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext( DbContextOptions<AppDbContext> options ) : base( options ) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parking>()
                .HasOne(p => p.Vehicle)
                .WithMany(v => v.Parkings)
                .HasForeignKey(p => p.VehicleID)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Parking>()
                .HasOne(p => p.Zone)
                .WithMany(z => z.Parkings)
                .HasForeignKey(p => p.ZoneID)
                .OnDelete(DeleteBehavior.Restrict); 
        }

        public DbSet<Parking> Parking {  get; set; }
       public DbSet<Zone> Zone { get; set; }
       public DbSet<User> User { get; set; }
       public DbSet<Vehicle> Vehicle { get; set; }

    }
}
