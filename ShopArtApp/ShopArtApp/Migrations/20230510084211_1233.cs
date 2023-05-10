using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class _1233 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Commands",
                newName: "IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_UserId",
                table: "Commands",
                newName: "IX_Commands_IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Commands",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_IdUser",
                table: "Commands",
                newName: "IX_Commands_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
