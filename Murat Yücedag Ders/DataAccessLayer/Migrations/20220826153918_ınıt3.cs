using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class ınıt3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_comments_BlogID",
                table: "comments",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_blogs_BlogID",
                table: "comments",
                column: "BlogID",
                principalTable: "blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_BlogID",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_BlogID",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "comments");
        }
    }
}
