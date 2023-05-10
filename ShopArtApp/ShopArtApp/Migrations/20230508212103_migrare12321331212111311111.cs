using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class migrare12321331212111311111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_UserIdUser",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserIdUser",
                table: "Commands",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_UserIdUser",
                table: "Commands",
                newName: "IX_Commands_UserId");

            migrationBuilder.RenameColumn(
                name: "UserIdUser",
                table: "BillAddresses",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BillAddresses_UserIdUser",
                table: "BillAddresses",
                newName: "IX_BillAddresses_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "IdUser");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Commands",
                newName: "UserIdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_UserId",
                table: "Commands",
                newName: "IX_Commands_UserIdUser");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BillAddresses",
                newName: "UserIdUser");

            migrationBuilder.RenameIndex(
                name: "IX_BillAddresses_UserId",
                table: "BillAddresses",
                newName: "IX_BillAddresses_UserIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserIdUser",
                table: "BillAddresses",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
