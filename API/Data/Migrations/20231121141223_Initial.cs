using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    NewsId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    addedon = table.Column<DateOnly>(type: "date", nullable: true),
                    discount = table.Column<int>(type: "integer", nullable: true),
                    images = table.Column<string[]>(type: "text[]", nullable: true)
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
                    { 1, "Desc Test", null, new DateOnly(2024, 1, 1), null, "News 1" },
                    { 2, "Desc Test", null, new DateOnly(2024, 1, 1), null, "News 2" },
                    { 3, "Desc Test", null, new DateOnly(2024, 1, 1), null, "News 3" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "addedon", "barcode", "category", "description", "descriptionbullets", "discount", "images", "name", "price" },
                values: new object[,]
                {
                    { new Guid("2d8cbb3b-03d2-4b95-996e-995675c1d7a8"), null, null, null, "Desc Test", null, null, null, "Product 1", 500 },
                    { new Guid("2fd68b95-3b2d-4fad-9e74-ac1c3764232c"), null, null, null, "Desc Test", null, null, null, "Product 4", 500 },
                    { new Guid("624c0805-fff1-484c-977c-2adb16d8da02"), null, null, null, "Desc Test", null, null, null, "Product 8", 500 },
                    { new Guid("77cbdad5-1012-4be6-85d8-2a3eec72372a"), null, null, null, "Desc Test", null, null, null, "Product 7", 500 },
                    { new Guid("901f4c46-46b8-486c-a918-b26859e95563"), null, null, null, "Desc Test", null, null, null, "Product 5", 500 },
                    { new Guid("b5360f9d-9ae6-456e-9daf-0f89f6c15431"), null, null, null, "Desc Test", null, null, null, "Product 2", 500 },
                    { new Guid("d69a5d7d-912d-44d7-8db8-1894b5f9e538"), null, null, null, "Desc Test", null, null, null, "Product 3", 500 },
                    { new Guid("f475dfcd-37b9-4065-a6ab-b86754e05b3f"), null, null, null, "Desc Test", null, null, null, "Product 6", 500 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "hashedpassword", "pass_salt", "username", "usertype" },
                values: new object[,]
                {
                    { new Guid("3907e15e-0a1d-4cae-9dbc-8107cc0f179d"), null, null, "admintest", "admin" },
                    { new Guid("6a400439-2c80-42bc-adc7-2f0e491f34a1"), null, null, "usertest", "user" }
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
