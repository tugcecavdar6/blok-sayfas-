using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig78 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "iletisims",
                columns: table => new
                {
                    iletisimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iletisimKullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iletisimmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iletisimbaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iletisimbesaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iletisimtarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    iletisimdurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iletisims", x => x.iletisimId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "iletisims");
        }
    }
}
