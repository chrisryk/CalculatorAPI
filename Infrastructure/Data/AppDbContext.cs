using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Operation> Operations { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operation>()
                .Property(o => o.FirstValue)
                .HasColumnType("decimal(38, 10)");

            modelBuilder.Entity<Operation>()
                .Property(o => o.SecondValue)
                .HasColumnType("decimal(38, 10)");

            modelBuilder.Entity<Operation>()
                .Property(o => o.Result)
                .HasColumnType("decimal(38, 10)");
        }
    }
}
