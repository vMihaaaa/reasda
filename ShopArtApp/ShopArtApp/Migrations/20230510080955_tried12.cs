using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class tried12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "BillAddressIdBillAddress",
                table: "Commands",
                newName: "BillAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_BillAddressIdBillAddress",
                table: "Commands",
                newName: "IX_Commands_BillAddressId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "BillAddressId",
                table: "Commands",
                newName: "BillAddressIdBillAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_BillAddressId",
                table: "Commands",
                newName: "IX_Commands_BillAddressIdBillAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressIdBillAddress",
                table: "Commands",
                column: "BillAddressIdBillAddress",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
