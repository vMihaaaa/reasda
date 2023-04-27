using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class modify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "IdProduct",
                table: "CommandDetails");

            migrationBuilder.RenameColumn(
                name: "UserIdUser",
                table: "Commands",
                newName: "userIdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_UserIdUser",
                table: "Commands",
                newName: "IX_Commands_userIdUser");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "ShoppingCarts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IdProduct",
                table: "ShoppingCarts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IdCategory",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IdBillAddress",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "IdCommandDetail",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCommand",
                table: "CommandDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "BillAddresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_userIdUser",
                table: "Commands",
                column: "userIdUser",
                principalTable: "Users",
                principalColumn: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_userIdUser",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "IdCommandDetail",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "userIdUser",
                table: "Commands",
                newName: "UserIdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_userIdUser",
                table: "Commands",
                newName: "IX_Commands_UserIdUser");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "ShoppingCarts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdProduct",
                table: "ShoppingCarts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdCategory",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdBillAddress",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCommand",
                table: "CommandDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdProduct",
                table: "CommandDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "BillAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser");
        }
    }
}
