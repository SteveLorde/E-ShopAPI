﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231222134701_addednavigationpropertytoproduct")]
    partial class addednavigationpropertytoproduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("API.Data.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ParentCategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"),
                            ParentCategoryId = new Guid("5cd3afb6-9c0f-11ee-8c90-0242ac120002"),
                            name = "Computer Hardware"
                        },
                        new
                        {
                            Id = new Guid("92c17ce6-92b8-4515-9fc3-e38fcc51d83e"),
                            ParentCategoryId = new Guid("5cd3afb6-9c0f-11ee-8c90-0242ac120002"),
                            name = "Mobiles and Accesories"
                        },
                        new
                        {
                            Id = new Guid("3ac2239f-3d70-4da0-b81e-bda272847e7c"),
                            ParentCategoryId = new Guid("733d2eda-9c0f-11ee-8c90-0242ac120002"),
                            name = "Kitchen and Appliances"
                        },
                        new
                        {
                            Id = new Guid("ef39fd90-d4fd-46aa-95bf-23672f549756"),
                            ParentCategoryId = new Guid("6d8e2cc8-9c0f-11ee-8c90-0242ac120002"),
                            name = "Vegetables"
                        },
                        new
                        {
                            Id = new Guid("f1c3a402-5e08-4e13-a08f-4d9ab5062a9e"),
                            ParentCategoryId = new Guid("5cd3afb6-9c0f-11ee-8c90-0242ac120002"),
                            name = "Video Games"
                        },
                        new
                        {
                            Id = new Guid("bb2dc742-a510-4a83-a0fa-e454df3a559c"),
                            ParentCategoryId = new Guid("5cd3afb6-9c0f-11ee-8c90-0242ac120002"),
                            name = "Tablets"
                        },
                        new
                        {
                            Id = new Guid("3e80f63e-6866-4a58-a7e7-8151b8c7c199"),
                            ParentCategoryId = new Guid("780fcde6-9c0f-11ee-8c90-0242ac120002"),
                            name = "Face and Hair"
                        });
                });

            modelBuilder.Entity("API.Data.Models.DiscountEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("discountamount")
                        .HasColumnType("numeric");

                    b.Property<string>("discountname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DiscountEvents");
                });

            modelBuilder.Entity("API.Data.Models.News", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("image")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("published")
                        .HasColumnType("date");

                    b.Property<string>("subtitle")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0d8b8ff5-db08-4ee0-ae55-dd0267116b5d"),
                            description = "Desc Test",
                            image = "newscover.jpg",
                            published = new DateOnly(2024, 1, 1),
                            title = "Christmas Discounts on Electronics"
                        },
                        new
                        {
                            Id = new Guid("1a55b12e-65b8-4542-b4c1-6676c30311e7"),
                            description = "Desc Test",
                            image = "newscover.jpg",
                            published = new DateOnly(2024, 1, 1),
                            title = "Shop Smart, Save Big: Exclusive Year-End Sale with Unbeatable Discounts!"
                        },
                        new
                        {
                            Id = new Guid("93097c20-6558-4ed9-a27e-8bf07fb59b8a"),
                            description = "Desc Test",
                            image = "newscover.jpg",
                            published = new DateOnly(2024, 1, 1),
                            title = "Digital Winter VideoGames Sales"
                        });
                });

            modelBuilder.Entity("API.Data.Models.ParentCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ParentCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5cd3afb6-9c0f-11ee-8c90-0242ac120002"),
                            name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("6d8e2cc8-9c0f-11ee-8c90-0242ac120002"),
                            name = "Groceries"
                        },
                        new
                        {
                            Id = new Guid("733d2eda-9c0f-11ee-8c90-0242ac120002"),
                            name = "Home and Garden"
                        },
                        new
                        {
                            Id = new Guid("780fcde6-9c0f-11ee-8c90-0242ac120002"),
                            name = "Beauty and Personal Care"
                        });
                });

            modelBuilder.Entity("API.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("DiscountEventId")
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("addedon")
                        .HasColumnType("date");

                    b.Property<int?>("barcode")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("descriptionbullets")
                        .HasColumnType("text");

                    b.Property<string[]>("images")
                        .HasColumnType("text[]");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("price")
                        .HasColumnType("integer");

                    b.Property<int?>("sells")
                        .HasColumnType("integer");

                    b.Property<int>("storequantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DiscountEventId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4eaf8297-449c-4aea-a656-a92b8730a201"),
                            CategoryId = new Guid("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"),
                            description = "Description Test",
                            images = new[] { "1.jpg", "2.jpg" },
                            name = "PC Build 2024",
                            price = 500,
                            storequantity = 0
                        },
                        new
                        {
                            Id = new Guid("4fe905ac-63ae-4e9c-a10f-b6379b594c18"),
                            CategoryId = new Guid("3e80f63e-6866-4a58-a7e7-8151b8c7c199"),
                            description = "Description Test",
                            images = new[] { "1.jpg", "2.jpg" },
                            name = "Face Cosmetic Kit",
                            price = 74,
                            storequantity = 0
                        },
                        new
                        {
                            Id = new Guid("45ee830f-a1f3-44ad-8112-982ef324dab4"),
                            CategoryId = new Guid("3e80f63e-6866-4a58-a7e7-8151b8c7c199"),
                            description = "Description Test",
                            images = new[] { "1.jpg", "2.jpg" },
                            name = "Hair Care Kit",
                            price = 200,
                            storequantity = 0
                        },
                        new
                        {
                            Id = new Guid("710df7a2-9cf9-4b80-89d5-20be76a621af"),
                            CategoryId = new Guid("3e80f63e-6866-4a58-a7e7-8151b8c7c199"),
                            description = "Description Test",
                            images = new[] { "1.jpg", "2.jpg" },
                            name = "Body Care Kit",
                            price = 1000,
                            storequantity = 0
                        },
                        new
                        {
                            Id = new Guid("4679e631-8273-49cd-91a6-fae714ea9d73"),
                            CategoryId = new Guid("f1c3a402-5e08-4e13-a08f-4d9ab5062a9e"),
                            description = "Description Test",
                            images = new[] { "1.jpg", "2.jpg" },
                            name = "Videogame",
                            price = 500,
                            storequantity = 0
                        },
                        new
                        {
                            Id = new Guid("b199f9b1-cf03-4990-876e-492df1cf69d1"),
                            CategoryId = new Guid("f1c3a402-5e08-4e13-a08f-4d9ab5062a9e"),
                            description = "Description Test",
                            images = new[] { "1.jpg", "2.jpg" },
                            name = "Playstation 5",
                            price = 500,
                            storequantity = 0
                        },
                        new
                        {
                            Id = new Guid("f741ceca-8eed-40a6-8706-3181886a2e23"),
                            CategoryId = new Guid("92c17ce6-92b8-4515-9fc3-e38fcc51d83e"),
                            description = "Description Test",
                            images = new[] { "1.jpg", "2.jpg" },
                            name = "Android Tablet",
                            price = 500,
                            storequantity = 0
                        },
                        new
                        {
                            Id = new Guid("f4411dd9-d96a-4104-9d33-30f7beb3ad05"),
                            CategoryId = new Guid("3ac2239f-3d70-4da0-b81e-bda272847e7c"),
                            description = "Description Test",
                            images = new[] { "1.jpg", "2.jpg" },
                            name = "Air Fryer",
                            price = 500,
                            storequantity = 0
                        });
                });

            modelBuilder.Entity("API.Data.Models.PurchaseLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<bool>("accepted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("datetime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("PurchaseLogs");
                });

            modelBuilder.Entity("API.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("hashedpassword")
                        .HasColumnType("text");

                    b.Property<string>("pass_salt")
                        .HasColumnType("text");

                    b.Property<int?>("phonenumber")
                        .HasColumnType("integer");

                    b.Property<string>("profileimage")
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("usertype")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c0c343f3-a9d0-4ae6-93e4-0d1923b04e60"),
                            email = "test@gmail.com",
                            phonenumber = 123456789,
                            profileimage = "profile.jpg",
                            username = "testuser",
                            usertype = "user"
                        });
                });

            modelBuilder.Entity("API.Data.Models.Category", b =>
                {
                    b.HasOne("API.Data.Models.ParentCategory", "ParentCategory")
                        .WithMany("Categories")
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("API.Data.Models.Product", b =>
                {
                    b.HasOne("API.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("API.Data.Models.DiscountEvent", "DiscountEvent")
                        .WithMany("Products")
                        .HasForeignKey("DiscountEventId");

                    b.Navigation("Category");

                    b.Navigation("DiscountEvent");
                });

            modelBuilder.Entity("API.Data.Models.PurchaseLog", b =>
                {
                    b.HasOne("API.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("API.Data.Models.DiscountEvent", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("API.Data.Models.ParentCategory", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
