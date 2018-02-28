using AspNetCoreMVC.Domain;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Product>().Property(p=>p.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>().Property(p=>p.Name).HasMaxLength(100).IsRequired();

        }
    }
}