using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotIdentity.ViewModels;

namespace NotIdentity.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser,AppRole,string>
    {

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {

        }

        public DbSet<NotIdentity.ViewModels.RoleViewModels> RoleViewModels { get; set; }

        public DbSet<NotIdentity.ViewModels.UserViewModel> UserViewModel { get; set; }


    }
}
