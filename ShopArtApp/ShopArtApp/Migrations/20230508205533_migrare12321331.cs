using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class migrare12321331 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses");

            migrationBuilder.DropIndex(
                name: "IX_BillAddresses_IdUser",
                table: "BillAddresses");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "BillAddresses");

            migrationBuilder.AddColumn<int>(
                name: "UserIdUser",
                table: "BillAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BillAddresses_UserIdUser",
                table: "BillAddresses",
                column: "UserIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserIdUser",
                table: "BillAddresses",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_UserIdUser",
                table: "BillAddresses");

            migrationBuilder.DropIndex(
                name: "IX_BillAddresses_UserIdUser",
                table: "BillAddresses");

            migrationBuilder.DropColumn(
                name: "UserIdUser",
                table: "BillAddresses");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "BillAddresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BillAddresses_IdUser",
                table: "BillAddresses",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser");
        }
    }
}
