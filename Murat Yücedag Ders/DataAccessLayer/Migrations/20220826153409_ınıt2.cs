using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class ınıt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_CategoryID",
                table: "blogs",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_categories_CategoryID",
                table: "blogs",
                column: "CategoryID",
                principalTable: "categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_categories_CategoryID",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_CategoryID",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "blogs");
        }
    }
}
