using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApiDemo.Migrations
{
    public partial class mig_yorum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Yorumlars",
                columns: table => new
                {
                    yorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yorumAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yorumBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yorumicerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yorumDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogScore = table.Column<int>(type: "int", nullable: false),
                    yorumDurum = table.Column<bool>(type: "bit", nullable: false),
                    BlogID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlars", x => x.yorumID);
                    table.ForeignKey(
                        name: "FK_Yorumlars_Blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blogs",
                        principalColumn: "BlogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_BlogID",
                table: "Yorumlars",
                column: "BlogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yorumlars");
        }
    }
}
