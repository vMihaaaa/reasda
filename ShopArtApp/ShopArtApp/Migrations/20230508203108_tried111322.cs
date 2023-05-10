using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class tried111322 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CommandDetails_IdCommand",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CommandDetails_IdCommandDetail",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_IdCommandDetail",
                table: "Commands");

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "Commands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_IdUser",
                table: "Commands",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "IdUser");
        }
    }
}
