using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class itried111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CommandDetails_CommandDetailIdCommandDetail",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ShoppingCarts_ShoppingCartId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ShoppingCartId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Products_CommandDetailIdCommandDetail",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdProduct",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "CommandDetailIdCommandDetail",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IdCommandDetail",
                table: "Commands");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommandDetailId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCommand",
                table: "CommandDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_IdUser",
                table: "ShoppingCarts",
                column: "IdUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CommandDetailId",
                table: "Products",
                column: "CommandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandDetails_IdCommand",
                table: "CommandDetails",
                column: "IdCommand",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails",
                column: "IdCommand",
                principalTable: "Commands",
                principalColumn: "IdCommand",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CommandDetails_CommandDetailId",
                table: "Products",
                column: "CommandDetailId",
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
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CommandDetails_CommandDetailId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_IdUser",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_Products_CommandDetailId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_CommandDetails_IdCommand",
                table: "CommandDetails");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "CommandDetailId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IdCommand",
                table: "CommandDetails");

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProduct",
                table: "ShoppingCarts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommandDetailIdCommandDetail",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCommandDetail",
                table: "Commands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ShoppingCartId",
                table: "Users",
                column: "ShoppingCartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CommandDetailIdCommandDetail",
                table: "Products",
                column: "CommandDetailIdCommandDetail");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands",
                column: "IdCommandDetail",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands",
                column: "IdCommandDetail",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CommandDetails_CommandDetailIdCommandDetail",
                table: "Products",
                column: "CommandDetailIdCommandDetail",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ShoppingCarts_ShoppingCartId",
                table: "Users",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "IdShoppingCart",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
