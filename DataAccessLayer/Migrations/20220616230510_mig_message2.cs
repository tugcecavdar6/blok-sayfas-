using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_message2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message2s_yazars_AliciId",
                table: "Message2s");

            migrationBuilder.DropForeignKey(
                name: "FK_Message2s_yazars_GonderenId",
                table: "Message2s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message2s",
                table: "Message2s");

            migrationBuilder.RenameTable(
                name: "Message2s",
                newName: "Messages2");

            migrationBuilder.RenameColumn(
                name: "MesajTarih",
                table: "Messages2",
                newName: "MessageDate");

            migrationBuilder.RenameColumn(
                name: "MesajDurum",
                table: "Messages2",
                newName: "MessageStatus");

            migrationBuilder.RenameColumn(
                name: "MesajDetay",
                table: "Messages2",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "Konu",
                table: "Messages2",
                newName: "MessageDetails");

            migrationBuilder.RenameColumn(
                name: "GonderenId",
                table: "Messages2",
                newName: "SenderId");

            migrationBuilder.RenameColumn(
                name: "AliciId",
                table: "Messages2",
                newName: "ReceiverId");

            migrationBuilder.RenameColumn(
                name: "MesajId",
                table: "Messages2",
                newName: "MessageId");

            migrationBuilder.RenameIndex(
                name: "IX_Message2s_GonderenId",
                table: "Messages2",
                newName: "IX_Messages2_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Message2s_AliciId",
                table: "Messages2",
                newName: "IX_Messages2_ReceiverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages2",
                table: "Messages2",
                column: "MessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages2_yazars_ReceiverId",
                table: "Messages2",
                column: "ReceiverId",
                principalTable: "yazars",
                principalColumn: "yazarID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages2_yazars_SenderId",
                table: "Messages2",
                column: "SenderId",
                principalTable: "yazars",
                principalColumn: "yazarID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages2_yazars_ReceiverId",
                table: "Messages2");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages2_yazars_SenderId",
                table: "Messages2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages2",
                table: "Messages2");

            migrationBuilder.RenameTable(
                name: "Messages2",
                newName: "Message2s");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Message2s",
                newName: "MesajDetay");

            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "Message2s",
                newName: "GonderenId");

            migrationBuilder.RenameColumn(
                name: "ReceiverId",
                table: "Message2s",
                newName: "AliciId");

            migrationBuilder.RenameColumn(
                name: "MessageStatus",
                table: "Message2s",
                newName: "MesajDurum");

            migrationBuilder.RenameColumn(
                name: "MessageDetails",
                table: "Message2s",
                newName: "Konu");

            migrationBuilder.RenameColumn(
                name: "MessageDate",
                table: "Message2s",
                newName: "MesajTarih");

            migrationBuilder.RenameColumn(
                name: "MessageId",
                table: "Message2s",
                newName: "MesajId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages2_SenderId",
                table: "Message2s",
                newName: "IX_Message2s_GonderenId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages2_ReceiverId",
                table: "Message2s",
                newName: "IX_Message2s_AliciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message2s",
                table: "Message2s",
                column: "MesajId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message2s_yazars_AliciId",
                table: "Message2s",
                column: "AliciId",
                principalTable: "yazars",
                principalColumn: "yazarID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message2s_yazars_GonderenId",
                table: "Message2s",
                column: "GonderenId",
                principalTable: "yazars",
                principalColumn: "yazarID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
