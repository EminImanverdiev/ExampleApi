using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection;
using WebApiAdvance.Entities;

namespace WebApiAdvance.DAL.EFCore
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options): base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>()
            //    .Property(p => p.Price)
            //    .IsRequired()
            //    .HasColumnType(SqlDbType.Float.ToString())
            //    .HasDefaultValue(0);
            //modelBuilder.Entity<Product>()
            //    .Property(p=>p.Name)
            //    .HasMaxLength(100)
            //    .HasColumnType(SqlDbType.NVarChar.ToString())
            //    .HasDefaultValue("PPPPP");
            //modelBuilder.Entity<Brand>()
            //    .Property(b => b.Name)
            //    .HasMaxLength(100)
            //    .HasColumnType(SqlDbType.NText.ToString())
            //    .HasDefaultValue("XXXXXX");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product>Products { get; set; }
        public DbSet<Brand>Brands { get; set; } 
        
    }
}
