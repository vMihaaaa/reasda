using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class updateIdRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdShoppingCart",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdCommandDetail",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IdCommandDetail",
                table: "Commands");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdShoppingCart",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCommandDetail",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCommandDetail",
                table: "Commands",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
