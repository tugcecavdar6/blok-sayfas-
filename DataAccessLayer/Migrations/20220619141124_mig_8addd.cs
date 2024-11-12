using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_8addd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_iletisim1s",
                table: "iletisim1s");

            migrationBuilder.RenameTable(
                name: "iletisim1s",
                newName: "iletisims");

            migrationBuilder.AddPrimaryKey(
                name: "PK_iletisims",
                table: "iletisims",
                column: "iletisimID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_iletisims",
                table: "iletisims");

            migrationBuilder.RenameTable(
                name: "iletisims",
                newName: "iletisim1s");

            migrationBuilder.AddPrimaryKey(
                name: "PK_iletisim1s",
                table: "iletisim1s",
                column: "iletisimID");
        }
    }
}
