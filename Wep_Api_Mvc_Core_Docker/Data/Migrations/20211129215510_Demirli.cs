using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.Migrations
{
    public partial class Demirli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tc = table.Column<string>(type: "character varying(250)", nullable: true),
                    Ad = table.Column<string>(type: "character varying(250)", nullable: true),
                    SoyAd = table.Column<string>(type: "character varying(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "anas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imageName = table.Column<string>(type: "character varying(250)", nullable: true),
                    Aciklama = table.Column<string>(type: "character varying(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "duyurus",
                columns: table => new
                {
                    DuyuruId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Aciklama = table.Column<string>(type: "character varying(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_duyurus", x => x.DuyuruId);
                });

            migrationBuilder.CreateTable(
                name: "odemelers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlockNumarası = table.Column<string>(type: "character varying(250)", nullable: true),
                    Ad = table.Column<string>(type: "character varying(250)", nullable: true),
                    Soyad = table.Column<string>(type: "character varying(250)", nullable: true),
                    Tutar = table.Column<int>(type: "integer", nullable: false),
                    Tarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_odemelers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "satıss",
                columns: table => new
                {
                    SatısId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imageName = table.Column<string>(type: "character varying(250)", nullable: true),
                    Aciklama = table.Column<string>(type: "character varying(250)", nullable: true),
                    Fiyat = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_satıss", x => x.SatısId);
                });

            migrationBuilder.CreateTable(
                name: "SiteSakinis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KonutNumarası = table.Column<string>(type: "character varying(250)", nullable: true),
                    Ad = table.Column<string>(type: "character varying(250)", nullable: true),
                    SoyAd = table.Column<string>(type: "character varying(250)", nullable: true),
                    Tc = table.Column<string>(type: "character varying(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSakinis", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "anas");

            migrationBuilder.DropTable(
                name: "duyurus");

            migrationBuilder.DropTable(
                name: "odemelers");

            migrationBuilder.DropTable(
                name: "satıss");

            migrationBuilder.DropTable(
                name: "SiteSakinis");
        }
    }
}
