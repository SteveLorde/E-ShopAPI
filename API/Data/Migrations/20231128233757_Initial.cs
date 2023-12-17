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
                    { new Guid("1668183c-29a9-4168-b6b5-06556cc8258c"), "Desc Test", "newscover.jpg", new DateOnly(2024, 1, 1), null, "News 3" },
                    { new Guid("97921fe9-4fea-4756-880d-d4df10d514ec"), "Desc Test", "newscover.jpg", new DateOnly(2024, 1, 1), null, "News 1" },
                    { new Guid("da015ff8-b47b-48c0-8353-fd3012c9a1b7"), "Desc Test", "newscover.jpg", new DateOnly(2024, 1, 1), null, "News 2" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "addedon", "barcode", "category", "description", "descriptionbullets", "discount", "images", "name", "price", "quantity", "sells" },
                values: new object[,]
                {
                    { new Guid("0a264458-6c83-4012-9be7-8e7c7eda0ab8"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 8", 500, 0, 0 },
                    { new Guid("0fe9cb6f-f2f5-4843-ae9a-e54d6b8ebdaa"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 4", 500, 5, 40 },
                    { new Guid("6f80aeee-13db-4074-aada-d6ba2852b6f8"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 6", 500, 6, 25 },
                    { new Guid("9bd81fdd-7322-4312-a208-4f34c8baaa16"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 5", 500, 4, 1 },
                    { new Guid("d395b056-9080-4b9f-9405-f9d531ade622"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 3", 500, 1, 15 },
                    { new Guid("d618b793-65d0-4b28-a48d-0cb76701ae31"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 1", 500, 50, 500 },
                    { new Guid("e0343d1d-f336-4f29-968e-53d1448c4be3"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 7", 500, 7, 0 },
                    { new Guid("e3a00c40-03d2-40b7-a566-b7f044481044"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 2", 500, 10, 50 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "hashedpassword", "pass_salt", "username", "usertype" },
                values: new object[,]
                {
                    { new Guid("19787d61-2a8f-41c7-83a0-02ac0f046731"), null, null, "usertest", "user" },
                    { new Guid("c2b867fb-e6be-4d78-a246-6631118f5a61"), null, null, "admintest", "admin" }
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
