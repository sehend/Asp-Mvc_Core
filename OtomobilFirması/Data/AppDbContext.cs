using Core.Model;
using Core.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class AppDbContext :IdentityDbContext <AppUser, AppRole, string>
    {
        public AppDbContext()
        {
        }

    
      
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
    
        public virtual DbSet<Anket> Ankets { get; set; }

        public virtual DbSet<AracBilgileri> AracBilgileris { get; set; }

        public virtual DbSet<MüsteriBilgileri> MüsteriBilgileris { get; set; }

        public virtual DbSet<Detay> Detays { get; set; }

        public DbSet<RoleViewModels> RoleViewModels { get; set; }

        public DbSet<UserViewModel> UserViewModel { get; set; }
    }
}
