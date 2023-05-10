using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class tried121223 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_BillAddressId",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "BillAddressId",
                table: "Commands");

            migrationBuilder.AddColumn<int>(
                name: "BillAddressIdBillAddress",
                table: "Commands",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Commands_BillAddressIdBillAddress",
                table: "Commands",
                column: "BillAddressIdBillAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressIdBillAddress",
                table: "Commands",
                column: "BillAddressIdBillAddress",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.AddColumn<int>(
                name: "BillAddressId",
                table: "Commands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Commands_BillAddressId",
                table: "Commands",
                column: "BillAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands",
                column: "BillAddressId",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress");
        }
    }
}
