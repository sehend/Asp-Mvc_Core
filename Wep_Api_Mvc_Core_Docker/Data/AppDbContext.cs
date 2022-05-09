using Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Db oluşma esnasında çalışır. ArticleConfiguration bu bölümde çalışır.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        public DbSet<Satıs> satıss { get; set; }

        public DbSet<Odemeler> odemelers { get; set; }

        public DbSet<Ana> anas { get; set; }

        public DbSet<Duyuru> duyurus { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<SiteSakini> SiteSakinis { get; set; }




    }
}
