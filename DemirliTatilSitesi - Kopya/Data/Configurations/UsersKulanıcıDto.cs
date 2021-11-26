using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    class UsersKulanıcıDto : IEntityTypeConfiguration<UsersKulanıcı>
    {

        public void Configure(EntityTypeBuilder<UsersKulanıcı> builder)
        {
            builder.Property(x => x.TC).HasMaxLength(12);
        }
    }
}
