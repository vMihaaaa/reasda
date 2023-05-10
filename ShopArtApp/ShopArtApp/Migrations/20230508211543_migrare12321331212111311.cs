using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class migrare12321331212111311 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Commands",
                newName: "UserIdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_UserId",
                table: "Commands",
                newName: "IX_Commands_UserIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "UserIdUser",
                table: "Commands",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_UserIdUser",
                table: "Commands",
                newName: "IX_Commands_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
