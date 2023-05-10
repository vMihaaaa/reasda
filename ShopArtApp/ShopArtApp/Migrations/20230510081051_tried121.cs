using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class tried121 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands",
                column: "BillAddressId",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands",
                column: "BillAddressId",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
