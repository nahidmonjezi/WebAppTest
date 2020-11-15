
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAppTest.Models.Entities;

namespace WebAppTest.Models
{
     
    public class dbContext:DbContext

    {
        public DbSet<Shop> Shops;
        public dbContext(DbContextOptions options):base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Shop>().HasQueryFilter(p => (p.Allow_Delete) == false);
            modelBuilder.Entity<Shop>().HasQueryFilter(p => EF.Property<bool>(p, "Allow_Delete") == false);
        }
    }
}