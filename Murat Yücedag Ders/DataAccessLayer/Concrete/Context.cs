using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BlockDb;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        public DbSet<About>? abouts { get; set; }

        public DbSet<Blog>? blogs { get; set; }

        public DbSet<Category>? categories { get; set; }

        public DbSet<Comment>? comments { get; set; }

        public DbSet<Contact>? contacts { get; set; }

        public DbSet<Writer>? writers { get; set; }
    }
}
