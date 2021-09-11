using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            //categories se , 2. parametre olarak " " içinde şemada verile bilir default db dir.

            builder.ToTable("Categories");


        }
    }
}
