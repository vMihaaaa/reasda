using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class tried : Migration
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
                name: "FK_Commands_Users_UserId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CommandDetails_CommandDetailId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CommandDetailId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Commands",
                newName: "IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_UserId",
                table: "Commands",
                newName: "IX_Commands_IdUser");

            migrationBuilder.AlterColumn<int>(
                name: "IdProduct",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CommandDetails_IdProduct",
                table: "Products",
                column: "IdProduct",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail");
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

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Commands",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_IdUser",
                table: "Commands",
                newName: "IX_Commands_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "IdProduct",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CommandDetailId",
                table: "Products",
                column: "CommandDetailId");

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
                name: "FK_Commands_Users_UserId",
                table: "Commands",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CommandDetails_CommandDetailId",
                table: "Products",
                column: "CommandDetailId",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
