using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApiDemo.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_BlogID",
                table: "Yorumlars",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_Blogs_BlogID",
                table: "Yorumlars",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_Blogs_BlogID",
                table: "Yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_Yorumlars_BlogID",
                table: "Yorumlars");
        }
    }
}
