using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class tried11132 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands");

            migrationBuilder.AlterColumn<int>(
                name: "IdCommand",
                table: "Commands",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_CommandDetails_IdCommand",
                table: "Commands",
                column: "IdCommand",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CommandDetails_IdCommand",
                table: "Commands");

            migrationBuilder.AlterColumn<int>(
                name: "IdCommand",
                table: "Commands",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands",
                column: "IdCommandDetail");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands",
                column: "IdCommandDetail",
                principalTable: "CommandDetails",
                principalColumn: "IdCommandDetail");
        }
    }
}
