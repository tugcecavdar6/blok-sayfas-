using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApiDemo.Migrations
{
    public partial class mig_addapi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Yazars",
                columns: table => new
                {
                    yazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yazarAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yazarHakkinda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yazarImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yazarMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yazarSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yazarDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazars", x => x.yazarID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blogicerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogkucukImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogDurum = table.Column<bool>(type: "bit", nullable: false),
                    kategoriID = table.Column<int>(type: "int", nullable: false),
                    yazarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                    table.ForeignKey(
                        name: "FK_Blogs_Yazars_yazarID",
                        column: x => x.yazarID,
                        principalTable: "Yazars",
                        principalColumn: "yazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_yazarID",
                table: "Blogs",
                column: "yazarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Yazars");
        }
    }
}
