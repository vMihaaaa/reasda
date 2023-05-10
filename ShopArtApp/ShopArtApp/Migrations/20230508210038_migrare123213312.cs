using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class migrare123213312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_IdBillAddress",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdBillAddress",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "IdBillAddress",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "IdCommand",
                table: "CommandDetails");

            migrationBuilder.AlterColumn<int>(
                name: "UserIdUser",
                table: "Commands",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillAddressIdBillAddress",
                table: "Commands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommandId",
                table: "CommandDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Commands_BillAddressIdBillAddress",
                table: "Commands",
                column: "BillAddressIdBillAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands",
                column: "IdCommandDetail",
                unique: true,
                filter: "[IdCommandDetail] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CommandDetails_CommandId",
                table: "CommandDetails",
                column: "CommandId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommandDetails_Commands_CommandId",
                table: "CommandDetails",
                column: "CommandId",
                principalTable: "Commands",
                principalColumn: "IdCommand",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressIdBillAddress",
                table: "Commands",
                column: "BillAddressIdBillAddress",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandDetails_Commands_CommandId",
                table: "CommandDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_CommandDetails_CommandId",
                table: "CommandDetails");

            migrationBuilder.DropColumn(
                name: "BillAddressIdBillAddress",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "CommandId",
                table: "CommandDetails");

            migrationBuilder.AlterColumn<int>(
                name: "UserIdUser",
                table: "Commands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdBillAddress",
                table: "Commands",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Commands",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCommand",
                table: "CommandDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Commands_IdBillAddress",
                table: "Commands",
                column: "IdBillAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands",
                column: "IdCommandDetail");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_IdBillAddress",
                table: "Commands",
                column: "IdBillAddress",
                principalTable: "BillAddresses",
                principalColumn: "IdBillAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserIdUser",
                table: "Commands",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser");
        }
    }
}
