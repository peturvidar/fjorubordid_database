using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _35 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b49fb04-66e5-4c56-934f-2e2fc530ac7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1be8d5c-3d6f-4087-96e3-036edcfbda3d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b9e7b892-659f-4db4-aaeb-81c030ee4488", null, "User", "USER" },
                    { "f5ecb54d-1b63-4097-9e27-1c89683f8f0e", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                column: "ImagePath",
                value: "humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "ImagePath",
                value: "humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3,
                column: "ImagePath",
                value: "humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4,
                column: "ImagePath",
                value: "humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5,
                column: "ImagePath",
                value: "humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6,
                column: "ImagePath",
                value: "supa.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7,
                column: "ImagePath",
                value: "supa.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8,
                column: "ImagePath",
                value: "green.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 9,
                column: "ImagePath",
                value: "lamb.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 10,
                column: "ImagePath",
                value: "naggar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 11,
                column: "ImagePath",
                value: "humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 12,
                column: "ImagePath",
                value: "dessert.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9e7b892-659f-4db4-aaeb-81c030ee4488");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5ecb54d-1b63-4097-9e27-1c89683f8f0e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5b49fb04-66e5-4c56-934f-2e2fc530ac7c", null, "Administrator", "ADMINISTRATOR" },
                    { "e1be8d5c-3d6f-4087-96e3-036edcfbda3d", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                column: "ImagePath",
                value: "https://localhost:8000/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "ImagePath",
                value: "https://localhost:8000/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3,
                column: "ImagePath",
                value: "https://localhost:8000/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4,
                column: "ImagePath",
                value: "https://localhost:8000/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5,
                column: "ImagePath",
                value: "https://localhost:8000/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6,
                column: "ImagePath",
                value: "https://localhost:8000/images/supa.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7,
                column: "ImagePath",
                value: "https://localhost:8000/images/supa.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8,
                column: "ImagePath",
                value: "https://localhost:8000/images/green.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 9,
                column: "ImagePath",
                value: "https://localhost:8000/images/lamb.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 10,
                column: "ImagePath",
                value: "https://localhost:8000/images/naggar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 11,
                column: "ImagePath",
                value: "https://localhost:8000/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 12,
                column: "ImagePath",
                value: "https://localhost:8000/images/dessert.jpg");
        }
    }
}
