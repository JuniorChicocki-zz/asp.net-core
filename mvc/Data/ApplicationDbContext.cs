using Microsoft.EntityFrameworkCore;
using MVC.Domain;

namespace MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products{get; set;}
        public DbSet<Category> Category{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(100);

            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>().Property(p => p.Name).HasMaxLength(50);
        }
    }
}
