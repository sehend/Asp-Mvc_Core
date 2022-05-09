using JWT.Core.Domain;
using JWT.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace JWT.Persistance.Context
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }

        public DbSet<Product>? products { get; set; }

        public DbSet<Category>? categories { get; set; }

        public DbSet<AppUser>? AppUsers { get; set; }

        public DbSet<AppRole>? AppRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ProductConfugarition());

            modelBuilder.ApplyConfiguration(new AppUserConfugarition());

            base.OnModelCreating(modelBuilder);
        }

    }
}
