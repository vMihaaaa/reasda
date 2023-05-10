using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class tried121222121w11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
