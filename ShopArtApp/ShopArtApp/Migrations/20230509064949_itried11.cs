using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class itried11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandDetails_Commands_CommandId",
                table: "CommandDetails");

            migrationBuilder.DropIndex(
                name: "IX_CommandDetails_CommandId",
                table: "CommandDetails");

            migrationBuilder.DropColumn(
                name: "CommandId",
                table: "CommandDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommandId",
                table: "CommandDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
