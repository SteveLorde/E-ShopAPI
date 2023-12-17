using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedphonenumberandemail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("6f3a894f-971e-4263-9b21-fb365aece3cb"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("77bdbdec-39fd-4d9b-9394-35089935216c"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("aaff248d-7772-4afb-acde-e868266d87af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4a2be4d1-3005-43ba-b6f2-aec5a303e47e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("63be51b6-cc02-4222-98cf-2ea124afe339"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7e345721-a6db-4a0f-902f-1f030e44838b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b1f12960-4467-49fe-9022-1e03722467e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b73f5721-f458-4d01-bbe1-05916ba24d90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bab17840-df31-4be6-8812-b18ef17a217d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bffcdd60-9026-44a9-a328-5ee73bfb47e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e23ebf47-8fcc-48ca-970c-a34e2520e0ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2f910c5d-c9d5-4391-a315-e6df614eb2a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a651951d-2ecf-4f00-a832-dcef9b859fc5"));

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "phonenumber",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PurchaseLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    accepted = table.Column<bool>(type: "boolean", nullable: false),
                    datetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseLogs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "NewsId", "description", "image", "published", "subtitle", "title" },
                values: new object[,]
                {
                    { new Guid("0d8b8ff5-db08-4ee0-ae55-dd0267116b5d"), "Desc Test", "newscover.jpg", new DateOnly(2024, 1, 1), null, "News 3" },
                    { new Guid("462235eb-997d-4731-856b-b7ca3865a337"), "Desc Test", "newscover.jpg", new DateOnly(2024, 1, 1), null, "News 2" },
                    { new Guid("bf0c7723-462d-4d60-97e8-7530c5c3ea33"), "Desc Test", "newscover.jpg", new DateOnly(2024, 1, 1), null, "News 1" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "addedon", "barcode", "category", "description", "descriptionbullets", "discount", "images", "name", "price", "quantity", "sells" },
                values: new object[,]
                {
                    { new Guid("45ee830f-a1f3-44ad-8112-982ef324dab4"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 5", 500, 4, 1 },
                    { new Guid("4679e631-8273-49cd-91a6-fae714ea9d73"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 2", 500, 10, 50 },
                    { new Guid("4eaf8297-449c-4aea-a656-a92b8730a201"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 8", 500, 0, 0 },
                    { new Guid("4fe905ac-63ae-4e9c-a10f-b6379b594c18"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 3", 500, 1, 15 },
                    { new Guid("710df7a2-9cf9-4b80-89d5-20be76a621af"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 6", 500, 6, 25 },
                    { new Guid("b199f9b1-cf03-4990-876e-492df1cf69d1"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 7", 500, 7, 0 },
                    { new Guid("f4411dd9-d96a-4104-9d33-30f7beb3ad05"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 1", 500, 50, 500 },
                    { new Guid("f741ceca-8eed-40a6-8706-3181886a2e23"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 4", 500, 5, 40 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "email", "hashedpassword", "pass_salt", "phonenumber", "username", "usertype" },
                values: new object[,]
                {
                    { new Guid("0a98ba08-74cd-4216-94aa-8f9993e7bb93"), null, null, null, null, "usertest", "user" },
                    { new Guid("82ad01d9-78dd-4f85-a82e-b261529cb4f4"), null, null, null, null, "admintest", "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseLogs_ProductId",
                table: "PurchaseLogs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseLogs_UserId",
                table: "PurchaseLogs",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseLogs");

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("0d8b8ff5-db08-4ee0-ae55-dd0267116b5d"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("462235eb-997d-4731-856b-b7ca3865a337"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("bf0c7723-462d-4d60-97e8-7530c5c3ea33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("45ee830f-a1f3-44ad-8112-982ef324dab4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4679e631-8273-49cd-91a6-fae714ea9d73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4eaf8297-449c-4aea-a656-a92b8730a201"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fe905ac-63ae-4e9c-a10f-b6379b594c18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("710df7a2-9cf9-4b80-89d5-20be76a621af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b199f9b1-cf03-4990-876e-492df1cf69d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f4411dd9-d96a-4104-9d33-30f7beb3ad05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f741ceca-8eed-40a6-8706-3181886a2e23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("0a98ba08-74cd-4216-94aa-8f9993e7bb93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("82ad01d9-78dd-4f85-a82e-b261529cb4f4"));

            migrationBuilder.DropColumn(
                name: "email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "phonenumber",
                table: "Users");

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "NewsId", "description", "image", "published", "subtitle", "title" },
                values: new object[,]
                {
                    { new Guid("6f3a894f-971e-4263-9b21-fb365aece3cb"), "Desc Test", "newscover.jpg", new DateOnly(2024, 1, 1), null, "News 2" },
                    { new Guid("77bdbdec-39fd-4d9b-9394-35089935216c"), "Desc Test", "newscover.jpg", new DateOnly(2024, 1, 1), null, "News 1" },
                    { new Guid("aaff248d-7772-4afb-acde-e868266d87af"), "Desc Test", "newscover.jpg", new DateOnly(2024, 1, 1), null, "News 3" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "addedon", "barcode", "category", "description", "descriptionbullets", "discount", "images", "name", "price", "quantity", "sells" },
                values: new object[,]
                {
                    { new Guid("4a2be4d1-3005-43ba-b6f2-aec5a303e47e"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 5", 500, 4, 1 },
                    { new Guid("63be51b6-cc02-4222-98cf-2ea124afe339"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 4", 500, 5, 40 },
                    { new Guid("7e345721-a6db-4a0f-902f-1f030e44838b"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 2", 500, 10, 50 },
                    { new Guid("b1f12960-4467-49fe-9022-1e03722467e7"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 3", 500, 1, 15 },
                    { new Guid("b73f5721-f458-4d01-bbe1-05916ba24d90"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 6", 500, 6, 25 },
                    { new Guid("bab17840-df31-4be6-8812-b18ef17a217d"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 8", 500, 0, 0 },
                    { new Guid("bffcdd60-9026-44a9-a328-5ee73bfb47e8"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 1", 500, 50, 500 },
                    { new Guid("e23ebf47-8fcc-48ca-970c-a34e2520e0ae"), null, null, null, "Desc Test", null, null, new[] { "1.jpg", "2.jpg", "3.jpg" }, "Product 7", 500, 7, 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "hashedpassword", "pass_salt", "username", "usertype" },
                values: new object[,]
                {
                    { new Guid("2f910c5d-c9d5-4391-a315-e6df614eb2a6"), null, null, "admintest", "admin" },
                    { new Guid("a651951d-2ecf-4f00-a832-dcef9b859fc5"), null, null, "usertest", "user" }
                });
        }
    }
}
