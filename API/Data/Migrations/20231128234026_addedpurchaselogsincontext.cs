using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedpurchaselogsincontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("1668183c-29a9-4168-b6b5-06556cc8258c"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("97921fe9-4fea-4756-880d-d4df10d514ec"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("da015ff8-b47b-48c0-8353-fd3012c9a1b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a264458-6c83-4012-9be7-8e7c7eda0ab8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0fe9cb6f-f2f5-4843-ae9a-e54d6b8ebdaa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6f80aeee-13db-4074-aada-d6ba2852b6f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9bd81fdd-7322-4312-a208-4f34c8baaa16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d395b056-9080-4b9f-9405-f9d531ade622"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d618b793-65d0-4b28-a48d-0cb76701ae31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e0343d1d-f336-4f29-968e-53d1448c4be3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e3a00c40-03d2-40b7-a566-b7f044481044"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("19787d61-2a8f-41c7-83a0-02ac0f046731"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("c2b867fb-e6be-4d78-a246-6631118f5a61"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
