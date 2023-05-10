using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class _1233111111111123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Commands",
                newName: "IdUser1");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_IdUser",
                table: "Commands",
                newName: "IX_Commands_IdUser1");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser1",
                table: "Commands",
                column: "IdUser1",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser1",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "IdUser1",
                table: "Commands",
                newName: "IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_IdUser1",
                table: "Commands",
                newName: "IX_Commands_IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
