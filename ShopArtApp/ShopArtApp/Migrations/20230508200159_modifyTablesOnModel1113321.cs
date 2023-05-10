using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class modifyTablesOnModel1113321 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_CommandDetails_IdCommand",
                table: "CommandDetails");

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "Commands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands",
                column: "IdCommandDetail");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands");

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "Commands",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_IdUser",
                table: "ShoppingCarts",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
