using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_notification1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationTurSembolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationDetay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotificationDurum = table.Column<bool>(type: "bit", nullable: false),
                    NotificationRengi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");
        }
    }
}
