using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedmoreproperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2d8cbb3b-03d2-4b95-996e-995675c1d7a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2fd68b95-3b2d-4fad-9e74-ac1c3764232c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("624c0805-fff1-484c-977c-2adb16d8da02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("77cbdad5-1012-4be6-85d8-2a3eec72372a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("901f4c46-46b8-486c-a918-b26859e95563"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b5360f9d-9ae6-456e-9daf-0f89f6c15431"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d69a5d7d-912d-44d7-8db8-1894b5f9e538"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f475dfcd-37b9-4065-a6ab-b86754e05b3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("3907e15e-0a1d-4cae-9dbc-8107cc0f179d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("6a400439-2c80-42bc-adc7-2f0e491f34a1"));

            migrationBuilder.AddColumn<int>(
                name: "sells",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "addedon", "barcode", "category", "description", "descriptionbullets", "discount", "images", "name", "price", "sells" },
                values: new object[,]
                {
                    { new Guid("26a5532d-c9c1-40a9-a81e-5d8d78386e54"), null, null, null, "Desc Test", null, null, null, "Product 3", 500, null },
                    { new Guid("2cdd1f5b-d448-4204-b43a-44406c04f08e"), null, null, null, "Desc Test", null, null, null, "Product 5", 500, null },
                    { new Guid("41eab0cc-08fc-43bb-84a9-977186e67a9d"), null, null, null, "Desc Test", null, null, null, "Product 1", 500, null },
                    { new Guid("705abb70-d8ab-4012-b4f0-2e6cc8bcab14"), null, null, null, "Desc Test", null, null, null, "Product 2", 500, null },
                    { new Guid("712e5618-e3d7-4ab9-8477-b8616aa3fce0"), null, null, null, "Desc Test", null, null, null, "Product 8", 500, null },
                    { new Guid("75d37063-512f-4c36-ad7a-f08f1433059c"), null, null, null, "Desc Test", null, null, null, "Product 6", 500, null },
                    { new Guid("ce7f7079-94a6-44b2-b2d9-761622aa19b8"), null, null, null, "Desc Test", null, null, null, "Product 7", 500, null },
                    { new Guid("f3d2ed66-8972-42bc-89d4-59303a95ac29"), null, null, null, "Desc Test", null, null, null, "Product 4", 500, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "hashedpassword", "pass_salt", "username", "usertype" },
                values: new object[,]
                {
                    { new Guid("8627a7c7-b55e-47c7-8ad5-39f20c83fd94"), null, null, "admintest", "admin" },
                    { new Guid("9a6e62c3-c15b-4519-a74d-c2ae7e7ffcb1"), null, null, "usertest", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("26a5532d-c9c1-40a9-a81e-5d8d78386e54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2cdd1f5b-d448-4204-b43a-44406c04f08e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("41eab0cc-08fc-43bb-84a9-977186e67a9d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("705abb70-d8ab-4012-b4f0-2e6cc8bcab14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("712e5618-e3d7-4ab9-8477-b8616aa3fce0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("75d37063-512f-4c36-ad7a-f08f1433059c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ce7f7079-94a6-44b2-b2d9-761622aa19b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f3d2ed66-8972-42bc-89d4-59303a95ac29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8627a7c7-b55e-47c7-8ad5-39f20c83fd94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9a6e62c3-c15b-4519-a74d-c2ae7e7ffcb1"));

            migrationBuilder.DropColumn(
                name: "sells",
                table: "Products");

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
    }
}
