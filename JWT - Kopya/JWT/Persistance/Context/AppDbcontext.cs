using JWT.Core.Domain;

using Microsoft.EntityFrameworkCore;

namespace JWT.Persistance.Context
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }

       

        public DbSet<AppUser>? AppUsers { get; set; }

        public DbSet<AppRole>? AppRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

          

            base.OnModelCreating(modelBuilder);
        }

    }
}
