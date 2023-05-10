using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class modifytablesfinally1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_IdBillAddress",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_IdBillAddress",
                table: "Commands",
                column: "IdBillAddress",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands",
                column: "IdCommandDetail",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_IdBillAddress",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_IdBillAddress",
                table: "Commands",
                column: "IdBillAddress",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands",
                column: "IdCommandDetail",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser");
        }
    }
}
