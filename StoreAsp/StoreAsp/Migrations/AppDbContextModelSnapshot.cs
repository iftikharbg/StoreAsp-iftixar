﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreAsp.DAL;

namespace StoreAsp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StoreAsp.Models.BasketItems", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("basketid")
                        .HasColumnType("int");

                    b.Property<int?>("productid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("basketid");

                    b.HasIndex("productid");

                    b.ToTable("basketItems");
                });

            modelBuilder.Entity("StoreAsp.Models.Baskets", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("usersid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("usersid");

                    b.ToTable("baskets");
                });

            modelBuilder.Entity("StoreAsp.Models.Categories", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("StoreAsp.Models.Favorites", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("favorites");
                });

            modelBuilder.Entity("StoreAsp.Models.FavoritesItems", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("favoriteid")
                        .HasColumnType("int");

                    b.Property<int?>("productid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("favoriteid");

                    b.HasIndex("productid");

                    b.ToTable("favoritesItems");
                });

            modelBuilder.Entity("StoreAsp.Models.Orders", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("productsid")
                        .HasColumnType("int");

                    b.Property<int?>("usersid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("productsid");

                    b.HasIndex("usersid");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("StoreAsp.Models.Products", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("categoriesid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categoriesid");

                    b.ToTable("products");
                });

            modelBuilder.Entity("StoreAsp.Models.Roles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("StoreAsp.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("roleid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("roleid");

                    b.ToTable("users");
                });

            modelBuilder.Entity("StoreAsp.Models.BasketItems", b =>
                {
                    b.HasOne("StoreAsp.Models.Baskets", "basket")
                        .WithMany()
                        .HasForeignKey("basketid");

                    b.HasOne("StoreAsp.Models.Products", "product")
                        .WithMany()
                        .HasForeignKey("productid");

                    b.Navigation("basket");

                    b.Navigation("product");
                });

            modelBuilder.Entity("StoreAsp.Models.Baskets", b =>
                {
                    b.HasOne("StoreAsp.Models.Users", "users")
                        .WithMany()
                        .HasForeignKey("usersid");

                    b.Navigation("users");
                });

            modelBuilder.Entity("StoreAsp.Models.Favorites", b =>
                {
                    b.HasOne("StoreAsp.Models.Users", "user")
                        .WithMany()
                        .HasForeignKey("userid");

                    b.Navigation("user");
                });

            modelBuilder.Entity("StoreAsp.Models.FavoritesItems", b =>
                {
                    b.HasOne("StoreAsp.Models.Favorites", "favorite")
                        .WithMany()
                        .HasForeignKey("favoriteid");

                    b.HasOne("StoreAsp.Models.Products", "product")
                        .WithMany()
                        .HasForeignKey("productid");

                    b.Navigation("favorite");

                    b.Navigation("product");
                });

            modelBuilder.Entity("StoreAsp.Models.Orders", b =>
                {
                    b.HasOne("StoreAsp.Models.Products", "products")
                        .WithMany()
                        .HasForeignKey("productsid");

                    b.HasOne("StoreAsp.Models.Users", "users")
                        .WithMany()
                        .HasForeignKey("usersid");

                    b.Navigation("products");

                    b.Navigation("users");
                });

            modelBuilder.Entity("StoreAsp.Models.Products", b =>
                {
                    b.HasOne("StoreAsp.Models.Categories", "categories")
                        .WithMany()
                        .HasForeignKey("categoriesid");

                    b.Navigation("categories");
                });

            modelBuilder.Entity("StoreAsp.Models.Users", b =>
                {
                    b.HasOne("StoreAsp.Models.Roles", "role")
                        .WithMany()
                        .HasForeignKey("roleid");

                    b.Navigation("role");
                });
#pragma warning restore 612, 618
        }
    }
}
