using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApiDemo.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorykategoriID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    kategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kategoricerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kategoridurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.kategoriID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategorykategoriID",
                table: "Blogs",
                column: "CategorykategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategorykategoriID",
                table: "Blogs",
                column: "CategorykategoriID",
                principalTable: "Categories",
                principalColumn: "kategoriID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategorykategoriID",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategorykategoriID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CategorykategoriID",
                table: "Blogs");
        }
    }
}
