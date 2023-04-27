using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    IdCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.IdCategory);
                });

            migrationBuilder.CreateTable(
                name: "CommandDetails",
                columns: table => new
                {
                    IdCommandDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCommand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    IdProduct = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandDetails", x => x.IdCommandDetail);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    IdShoppingCart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantity = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    IdProduct = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.IdShoppingCart);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCategory = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CommandDetailIdCommandDetail = table.Column<int>(type: "int", nullable: false),
                    IdCommandDetail = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProduct);
                    table.ForeignKey(
                        name: "FK_Products_CommandDetails_CommandDetailIdCommandDetail",
                        column: x => x.CommandDetailIdCommandDetail,
                        principalTable: "CommandDetails",
                        principalColumn: "IdCommandDetail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfSignIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    shoppingCartIdShoppingCart = table.Column<int>(type: "int", nullable: false),
                    IdShoppingCart = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Users_ShoppingCarts_shoppingCartIdShoppingCart",
                        column: x => x.shoppingCartIdShoppingCart,
                        principalTable: "ShoppingCarts",
                        principalColumn: "IdShoppingCart",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesIdCategory = table.Column<int>(type: "int", nullable: false),
                    ProductsIdProduct = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesIdCategory, x.ProductsIdProduct });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesIdCategory",
                        column: x => x.CategoriesIdCategory,
                        principalTable: "Categories",
                        principalColumn: "IdCategory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsIdProduct",
                        column: x => x.ProductsIdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductShoppingCart",
                columns: table => new
                {
                    ProductsIdProduct = table.Column<int>(type: "int", nullable: false),
                    shoppingCartsIdShoppingCart = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShoppingCart", x => new { x.ProductsIdProduct, x.shoppingCartsIdShoppingCart });
                    table.ForeignKey(
                        name: "FK_ProductShoppingCart_Products_ProductsIdProduct",
                        column: x => x.ProductsIdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductShoppingCart_ShoppingCarts_shoppingCartsIdShoppingCart",
                        column: x => x.shoppingCartsIdShoppingCart,
                        principalTable: "ShoppingCarts",
                        principalColumn: "IdShoppingCart",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillAddresses",
                columns: table => new
                {
                    IdBillAddress = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    UserIdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillAddresses", x => x.IdBillAddress);
                    table.ForeignKey(
                        name: "FK_BillAddresses_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commands",
                columns: table => new
                {
                    IdCommand = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: false),
                    DateCommand = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdBillAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillAddressIdBillAddress = table.Column<int>(type: "int", nullable: false),
                    CommandDetailIdCommandDetail = table.Column<int>(type: "int", nullable: false),
                    IdCommandDetail = table.Column<int>(type: "int", nullable: false),
                    UserIdUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.IdCommand);
                    table.ForeignKey(
                        name: "FK_Commands_BillAddresses_BillAddressIdBillAddress",
                        column: x => x.BillAddressIdBillAddress,
                        principalTable: "BillAddresses",
                        principalColumn: "IdBillAddress",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commands_CommandDetails_CommandDetailIdCommandDetail",
                        column: x => x.CommandDetailIdCommandDetail,
                        principalTable: "CommandDetails",
                        principalColumn: "IdCommandDetail",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commands_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillAddresses_UserIdUser",
                table: "BillAddresses",
                column: "UserIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsIdProduct",
                table: "CategoryProduct",
                column: "ProductsIdProduct");

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
                name: "IX_Products_CommandDetailIdCommandDetail",
                table: "Products",
                column: "CommandDetailIdCommandDetail");

            migrationBuilder.CreateIndex(
                name: "IX_ProductShoppingCart_shoppingCartsIdShoppingCart",
                table: "ProductShoppingCart",
                column: "shoppingCartsIdShoppingCart");

            migrationBuilder.CreateIndex(
                name: "IX_Users_shoppingCartIdShoppingCart",
                table: "Users",
                column: "shoppingCartIdShoppingCart");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Commands");

            migrationBuilder.DropTable(
                name: "ProductShoppingCart");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "BillAddresses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CommandDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");
        }
    }
}
