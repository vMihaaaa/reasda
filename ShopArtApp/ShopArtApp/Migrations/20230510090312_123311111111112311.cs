using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class _123311111111112311 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser1",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "IdUser1",
                table: "Commands",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_IdUser1",
                table: "Commands",
                newName: "IX_Commands_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Commands",
                newName: "IdUser1");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_UserId",
                table: "Commands",
                newName: "IX_Commands_IdUser1");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser1",
                table: "Commands",
                column: "IdUser1",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
