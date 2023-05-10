using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class modifyTablesOnModel11133 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CommandDetails_Commands_IdCommandDetail",
                table: "CommandDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ShoppingCarts_ShoppingCartIdShoppingCart",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ShoppingCartIdShoppingCart",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ShoppingCartIdShoppingCart",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "IdCommandDetail",
                table: "CommandDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_IdUser",
                table: "ShoppingCarts",
                column: "IdUser",
                unique: true,
                filter: "[IdUser] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CommandDetails_IdCommand",
                table: "CommandDetails",
                column: "IdCommand",
                unique: true,
                filter: "[IdCommand] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails",
                column: "IdCommand",
                principalTable: "Commands",
                principalColumn: "IdCommand",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_IdUser",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_CommandDetails_IdCommand",
                table: "CommandDetails");

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartIdShoppingCart",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdCommandDetail",
                table: "CommandDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ShoppingCartIdShoppingCart",
                table: "Users",
                column: "ShoppingCartIdShoppingCart");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_CommandDetails_Commands_IdCommandDetail",
                table: "CommandDetails",
                column: "IdCommandDetail",
                principalTable: "Commands",
                principalColumn: "IdCommand",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ShoppingCarts_ShoppingCartIdShoppingCart",
                table: "Users",
                column: "ShoppingCartIdShoppingCart",
                principalTable: "ShoppingCarts",
                principalColumn: "IdShoppingCart");
        }
    }
}
