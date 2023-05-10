using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class _1233111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CommandDetails_IdProduct",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails",
                column: "IdCommand",
                principalTable: "Commands",
                principalColumn: "IdCommand",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CommandDetails_IdProduct",
                table: "Products",
                column: "IdProduct",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CommandDetails_IdProduct",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails",
                column: "IdCommand",
                principalTable: "Commands",
                principalColumn: "IdCommand");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CommandDetails_IdProduct",
                table: "Products",
                column: "IdProduct",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
