using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class modifytables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_UserIdUser",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CommandDetails_CommandDetailIdCommandDetail",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_CommandDetailIdCommandDetail",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_UserIdUser",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_BillAddresses_UserIdUser",
                table: "BillAddresses");

            migrationBuilder.DropColumn(
                name: "BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "CommandDetailIdCommandDetail",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "UserIdUser",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "UserIdUser",
                table: "BillAddresses");

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "Commands",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdCommandDetail",
                table: "Commands",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdBillAddress",
                table: "Commands",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdCommand",
                table: "CommandDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Commands_IdBillAddress",
                table: "Commands",
                column: "IdBillAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands",
                column: "IdCommandDetail");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_IdUser",
                table: "Commands",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_BillAddresses_IdUser",
                table: "BillAddresses",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.DropForeignKey(
            name: "FK_Commands_Users_IdUser",
            table: "Commands");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_IdUser",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_IdBillAddress",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdBillAddress",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdUser",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_BillAddresses_IdUser",
                table: "BillAddresses");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCommandDetail",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdBillAddress",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillAddressIdBillAddress",
                table: "Commands",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommandDetailIdCommandDetail",
                table: "Commands",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserIdUser",
                table: "Commands",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCommand",
                table: "CommandDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserIdUser",
                table: "BillAddresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Commands_BillAddressIdBillAddress",
                table: "Commands",
                column: "BillAddressIdBillAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_CommandDetailIdCommandDetail",
                table: "Commands",
                column: "CommandDetailIdCommandDetail");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_UserIdUser",
                table: "Commands",
                column: "UserIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_BillAddresses_UserIdUser",
                table: "BillAddresses",
                column: "UserIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserIdUser",
                table: "BillAddresses",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressIdBillAddress",
                table: "Commands",
                column: "BillAddressIdBillAddress",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_CommandDetails_CommandDetailIdCommandDetail",
                table: "Commands",
                column: "CommandDetailIdCommandDetail",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail");


            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.DropForeignKey(
            name: "FK_Commands_Users_IdUser",
            table: "Commands");
        }
    }
}
