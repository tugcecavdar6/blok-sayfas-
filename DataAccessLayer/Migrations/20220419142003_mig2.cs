using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "yorumlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_yorumlars_BlogID",
                table: "yorumlars",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_yorumlars_blogs_BlogID",
                table: "yorumlars",
                column: "BlogID",
                principalTable: "blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yorumlars_blogs_BlogID",
                table: "yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_yorumlars_BlogID",
                table: "yorumlars");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "yorumlars");
        }
    }
}
