﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Core.Model.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("character varying(250)");

                    b.Property<string>("SoyAd")
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Tc")
                        .HasColumnType("character varying(250)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Core.Model.Ana", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("character varying(250)");

                    b.Property<string>("imageName")
                        .HasColumnType("character varying(250)");

                    b.HasKey("Id");

                    b.ToTable("anas");
                });

            modelBuilder.Entity("Core.Model.Duyuru", b =>
                {
                    b.Property<int>("DuyuruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("character varying(250)");

                    b.HasKey("DuyuruId");

                    b.ToTable("duyurus");
                });

            modelBuilder.Entity("Core.Model.Odemeler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("character varying(250)");

                    b.Property<string>("BlockNumarası")
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Soyad")
                        .HasColumnType("character varying(250)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Tutar")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("odemelers");
                });

            modelBuilder.Entity("Core.Model.Satıs", b =>
                {
                    b.Property<int>("SatısId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("character varying(250)");

                    b.Property<int>("Fiyat")
                        .HasColumnType("integer");

                    b.Property<string>("imageName")
                        .HasColumnType("character varying(250)");

                    b.HasKey("SatısId");

                    b.ToTable("satıss");
                });

            modelBuilder.Entity("Core.Model.SiteSakini", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("character varying(250)");

                    b.Property<string>("KonutNumarası")
                        .HasColumnType("character varying(250)");

                    b.Property<string>("SoyAd")
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Tc")
                        .HasColumnType("character varying(250)");

                    b.HasKey("Id");

                    b.ToTable("SiteSakinis");
                });
#pragma warning restore 612, 618
        }
    }
}
