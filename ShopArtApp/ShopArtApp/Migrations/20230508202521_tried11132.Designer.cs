﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopArtApp.DataAcces.Context;

#nullable disable

namespace ShopArtApp.Migrations
{
    [DbContext(typeof(ShopArtAppContext))]
    [Migration("20230508202521_tried11132")]
    partial class tried11132
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesIdCategory")
                        .HasColumnType("int");

                    b.Property<int>("ProductsIdProduct")
                        .HasColumnType("int");

                    b.HasKey("CategoriesIdCategory", "ProductsIdProduct");

                    b.HasIndex("ProductsIdProduct");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("ProductShoppingCart", b =>
                {
                    b.Property<int>("ProductsIdProduct")
                        .HasColumnType("int");

                    b.Property<int>("shoppingCartsIdShoppingCart")
                        .HasColumnType("int");

                    b.HasKey("ProductsIdProduct", "shoppingCartsIdShoppingCart");

                    b.HasIndex("shoppingCartsIdShoppingCart");

                    b.ToTable("ProductShoppingCart");
                });

            modelBuilder.Entity("ShopArtApp.Models.BillAddress", b =>
                {
                    b.Property<int>("IdBillAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBillAddress"), 1L, 1);

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBillAddress");

                    b.HasIndex("IdUser");

                    b.ToTable("BillAddresses");
                });

            modelBuilder.Entity("ShopArtApp.Models.Category", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategory"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShopArtApp.Models.Command", b =>
                {
                    b.Property<int>("IdCommand")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCommand")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdBillAddress")
                        .HasColumnType("int");

                    b.Property<int?>("IdCommandDetail")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("IdCommand");

                    b.HasIndex("IdBillAddress");

                    b.HasIndex("IdUser");

                    b.ToTable("Commands");
                });

            modelBuilder.Entity("ShopArtApp.Models.CommandDetail", b =>
                {
                    b.Property<int>("IdCommandDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCommandDetail"), 1L, 1);

                    b.Property<int>("Cantity")
                        .HasColumnType("int");

                    b.Property<int?>("IdCommand")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("IdCommandDetail");

                    b.ToTable("CommandDetails");
                });

            modelBuilder.Entity("ShopArtApp.Models.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduct"), 1L, 1);

                    b.Property<int?>("CommandDetailIdCommandDetail")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("IdProduct");

                    b.HasIndex("CommandDetailIdCommandDetail");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShopArtApp.Models.ShoppingCart", b =>
                {
                    b.Property<int>("IdShoppingCart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdShoppingCart"), 1L, 1);

                    b.Property<int>("Cantity")
                        .HasColumnType("int");

                    b.Property<int?>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("IdShoppingCart");

                    b.HasIndex("IdUser")
                        .IsUnique()
                        .HasFilter("[IdUser] IS NOT NULL");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("ShopArtApp.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"), 1L, 1);

                    b.Property<DateTime>("DateOfSignIn")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("ShopArtApp.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesIdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopArtApp.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsIdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductShoppingCart", b =>
                {
                    b.HasOne("ShopArtApp.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsIdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopArtApp.Models.ShoppingCart", null)
                        .WithMany()
                        .HasForeignKey("shoppingCartsIdShoppingCart")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopArtApp.Models.BillAddress", b =>
                {
                    b.HasOne("ShopArtApp.Models.User", "User")
                        .WithMany("BillAddresses")
                        .HasForeignKey("IdUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopArtApp.Models.Command", b =>
                {
                    b.HasOne("ShopArtApp.Models.BillAddress", "BillAddress")
                        .WithMany()
                        .HasForeignKey("IdBillAddress");

                    b.HasOne("ShopArtApp.Models.CommandDetail", "CommandDetail")
                        .WithOne("Command")
                        .HasForeignKey("ShopArtApp.Models.Command", "IdCommand")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopArtApp.Models.User", "User")
                        .WithMany("Commands")
                        .HasForeignKey("IdUser");

                    b.Navigation("BillAddress");

                    b.Navigation("CommandDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopArtApp.Models.Product", b =>
                {
                    b.HasOne("ShopArtApp.Models.CommandDetail", "CommandDetail")
                        .WithMany("Products")
                        .HasForeignKey("CommandDetailIdCommandDetail");

                    b.Navigation("CommandDetail");
                });

            modelBuilder.Entity("ShopArtApp.Models.ShoppingCart", b =>
                {
                    b.HasOne("ShopArtApp.Models.User", "User")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("ShopArtApp.Models.ShoppingCart", "IdUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopArtApp.Models.CommandDetail", b =>
                {
                    b.Navigation("Command")
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShopArtApp.Models.User", b =>
                {
                    b.Navigation("BillAddresses");

                    b.Navigation("Commands");

                    b.Navigation("ShoppingCart");
                });
#pragma warning restore 612, 618
        }
    }
}
