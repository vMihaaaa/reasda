using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class _123311111111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_IdBillAddress",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_UserId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdBillAddress",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "IdBillAddress",
                table: "Commands");

            migrationBuilder.AddColumn<int>(
                name: "shoppingCartId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "IdShoppingCart",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_IdShoppingCart",
                table: "ShoppingCarts",
                column: "IdShoppingCart",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_IdShoppingCart",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_Commands_BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "shoppingCartId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.AlterColumn<int>(
                name: "IdShoppingCart",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdBillAddress",
                table: "Commands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Commands_IdBillAddress",
                table: "Commands",
                column: "IdBillAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_IdBillAddress",
                table: "Commands",
                column: "IdBillAddress",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_UserId",
                table: "ShoppingCarts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
