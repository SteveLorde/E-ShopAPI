using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    subtitle = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    published = table.Column<DateOnly>(type: "date", nullable: true),
                    image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    descriptionbullets = table.Column<string>(type: "text", nullable: true),
                    category = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: true),
                    barcode = table.Column<int>(type: "integer", nullable: true),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    addedon = table.Column<DateOnly>(type: "date", nullable: true),
                    discount = table.Column<int>(type: "integer", nullable: true),
                    images = table.Column<string[]>(type: "text[]", nullable: true),
                    sells = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    username = table.Column<string>(type: "text", nullable: false),
                    pass_salt = table.Column<string>(type: "text", nullable: true),
                    hashedpassword = table.Column<string>(type: "text", nullable: true),
                    usertype = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "NewsId", "description", "image", "published", "subtitle", "title" },
                values: new object[,]
                {
                    { new Guid("207fac73-e220-45e3-bb0c-deef5a3f50de"), "Desc Test", null, new DateOnly(2024, 1, 1), null, "News 3" },
                    { new Guid("2807756c-dfc8-4d5d-8964-db8f7a218aba"), "Desc Test", null, new DateOnly(2024, 1, 1), null, "News 1" },
                    { new Guid("5ff78de2-32c8-4d10-b9e6-61d3965d78de"), "Desc Test", null, new DateOnly(2024, 1, 1), null, "News 2" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "addedon", "barcode", "category", "description", "descriptionbullets", "discount", "images", "name", "price", "quantity", "sells" },
                values: new object[,]
                {
                    { new Guid("18a15403-e61f-4622-843b-3c754a1116cd"), null, null, null, "Desc Test", null, null, null, "Product 7", 500, 7, 0 },
                    { new Guid("20d29cd7-a918-4141-8fc1-c18e6436d2a8"), null, null, null, "Desc Test", null, null, null, "Product 2", 500, 10, 50 },
                    { new Guid("4f4776bf-5329-461e-8651-fc0da49b915e"), null, null, null, "Desc Test", null, null, null, "Product 6", 500, 6, 25 },
                    { new Guid("5bef0c5c-207b-4b6d-8e57-9de6483172c5"), null, null, null, "Desc Test", null, null, null, "Product 5", 500, 4, 1 },
                    { new Guid("66cd93d1-1cf2-4c1a-b4fb-a2f9d94e3d70"), null, null, null, "Desc Test", null, null, null, "Product 1", 500, 50, 500 },
                    { new Guid("6a0d1268-e719-40c2-a2ee-bd3227ac2777"), null, null, null, "Desc Test", null, null, null, "Product 8", 500, 0, 0 },
                    { new Guid("848fb490-1617-4fb0-b243-07d8da2812b1"), null, null, null, "Desc Test", null, null, null, "Product 3", 500, 1, 15 },
                    { new Guid("e738d355-26b7-434d-948a-17827808fc11"), null, null, null, "Desc Test", null, null, null, "Product 4", 500, 5, 40 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "hashedpassword", "pass_salt", "username", "usertype" },
                values: new object[,]
                {
                    { new Guid("a45910a9-c485-4288-81c7-ecbdbf898657"), null, null, "usertest", "user" },
                    { new Guid("a8e1bf9a-277c-47f8-add4-66849519c8f1"), null, null, "admintest", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
