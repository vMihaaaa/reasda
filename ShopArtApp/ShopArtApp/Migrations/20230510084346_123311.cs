using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class _123311 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
