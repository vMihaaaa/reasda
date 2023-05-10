using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class migrare12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails");

            migrationBuilder.DropIndex(
                name: "IX_CommandDetails_IdCommand",
                table: "CommandDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CommandDetails_IdCommand",
                table: "CommandDetails",
                column: "IdCommand");

            migrationBuilder.AddForeignKey(
                name: "FK_CommandDetails_Commands_IdCommand",
                table: "CommandDetails",
                column: "IdCommand",
                principalTable: "Commands",
                principalColumn: "IdCommand",
                onUpdate: ReferentialAction.Cascade,    // add the desired action for update
    onDelete: ReferentialAction.Restrict);
        }
    }
}
