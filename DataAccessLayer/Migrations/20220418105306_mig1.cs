using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
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
                    table.PrimaryKey("PK_categories", x => x.kategoriID);
                });

            migrationBuilder.CreateTable(
                name: "hakkimdas",
                columns: table => new
                {
                    hakkimdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hakkimdaDetay1 = table.Column<int>(type: "int", nullable: false),
                    hakkimdaDetay2 = table.Column<int>(type: "int", nullable: false),
                    hakkimdaImg1 = table.Column<int>(type: "int", nullable: false),
                    hakkimdaImg2 = table.Column<int>(type: "int", nullable: false),
                    hakkimdaHaritaLokasyon = table.Column<int>(type: "int", nullable: false),
                    hakkimdaDurum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hakkimdas", x => x.hakkimdaID);
                });

            migrationBuilder.CreateTable(
                name: "iletisims",
                columns: table => new
                {
                    iletisimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iletisimKullaniciAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iletisimMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iletisimBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iletisimMesaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iletisimDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    iletisimDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iletisims", x => x.iletisimID);
                });

            migrationBuilder.CreateTable(
                name: "yazars",
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
                    table.PrimaryKey("PK_yazars", x => x.yazarID);
                });

            migrationBuilder.CreateTable(
                name: "yorumlars",
                columns: table => new
                {
                    yorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yorumAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yorumBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yorumicerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yorumDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    yorumDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yorumlars", x => x.yorumID);
                });

            migrationBuilder.CreateTable(
                name: "blogs",
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
                    CategorykategoriID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.BlogID);
                    table.ForeignKey(
                        name: "FK_blogs_categories_CategorykategoriID",
                        column: x => x.CategorykategoriID,
                        principalTable: "categories",
                        principalColumn: "kategoriID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogs_CategorykategoriID",
                table: "blogs",
                column: "CategorykategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "hakkimdas");

            migrationBuilder.DropTable(
                name: "iletisims");

            migrationBuilder.DropTable(
                name: "yazars");

            migrationBuilder.DropTable(
                name: "yorumlars");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
