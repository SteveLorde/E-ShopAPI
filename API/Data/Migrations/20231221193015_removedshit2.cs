using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class removedshit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "parentcategoryname",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "parentcategoryname",
                table: "Categories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ac2239f-3d70-4da0-b81e-bda272847e7c"),
                column: "parentcategoryname",
                value: "Home and Garden");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e80f63e-6866-4a58-a7e7-8151b8c7c199"),
                column: "parentcategoryname",
                value: "Beauty and Personal Care");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92c17ce6-92b8-4515-9fc3-e38fcc51d83e"),
                column: "parentcategoryname",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb2dc742-a510-4a83-a0fa-e454df3a559c"),
                column: "parentcategoryname",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"),
                column: "parentcategoryname",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef39fd90-d4fd-46aa-95bf-23672f549756"),
                column: "parentcategoryname",
                value: "Groceries");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1c3a402-5e08-4e13-a08f-4d9ab5062a9e"),
                column: "parentcategoryname",
                value: "Electronics");
        }
    }
}
