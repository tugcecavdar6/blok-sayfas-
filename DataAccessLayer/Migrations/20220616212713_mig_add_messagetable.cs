using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_messagetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message2s",
                columns: table => new
                {
                    MesajId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GonderenId = table.Column<int>(type: "int", nullable: true),
                    AliciId = table.Column<int>(type: "int", nullable: true),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajDetay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesajDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message2s", x => x.MesajId);
                    table.ForeignKey(
                        name: "FK_Message2s_yazars_AliciId",
                        column: x => x.AliciId,
                        principalTable: "yazars",
                        principalColumn: "yazarID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message2s_yazars_GonderenId",
                        column: x => x.GonderenId,
                        principalTable: "yazars",
                        principalColumn: "yazarID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_AliciId",
                table: "Message2s",
                column: "AliciId");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_GonderenId",
                table: "Message2s",
                column: "GonderenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message2s");
        }
    }
}
