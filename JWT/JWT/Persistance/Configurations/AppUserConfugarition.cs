using JWT.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWT.Persistance.Configurations
{
    public class AppUserConfugarition : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(x => x.AppRoles).WithMany(x => x.appUsers).HasForeignKey(x => x.AppRoleId);
        }
    }

    public class ProductConfugarition : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.Category).WithMany(x => x.products).HasForeignKey(x => x.CategoryId);
        }
    }
}
