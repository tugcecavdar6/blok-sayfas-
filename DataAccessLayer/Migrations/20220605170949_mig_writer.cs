using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_writer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "yazarID",
                table: "blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_yazarID",
                table: "blogs",
                column: "yazarID");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_yazars_yazarID",
                table: "blogs",
                column: "yazarID",
                principalTable: "yazars",
                principalColumn: "yazarID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_yazars_yazarID",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_yazarID",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "yazarID",
                table: "blogs");
        }
    }
}
