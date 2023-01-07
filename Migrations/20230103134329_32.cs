using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a0c29bf-b160-43d2-a6a7-5e5acbbad82c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a2b6d2c-f205-44e5-876b-a3c438de01ec");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1bbb4ca9-551a-4e73-ad2b-6f599cdc6e5e", null, "Administrator", "ADMINISTRATOR" },
                    { "4919ebf5-28df-416d-a25f-6b1182b2d60b", null, "User", "USER" }
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
                value: "https://localhost:8000/images/súpa.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7,
                column: "ImagePath",
                value: "https://localhost:8000/images/súpa.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8,
                column: "ImagePath",
                value: "https://localhost:8000/images/grænn.JPG");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bbb4ca9-551a-4e73-ad2b-6f599cdc6e5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4919ebf5-28df-416d-a25f-6b1182b2d60b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a0c29bf-b160-43d2-a6a7-5e5acbbad82c", null, "User", "USER" },
                    { "9a2b6d2c-f205-44e5-876b-a3c438de01ec", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                column: "ImagePath",
                value: "wwwroot/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "ImagePath",
                value: "wwwroot/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3,
                column: "ImagePath",
                value: "wwwroot/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4,
                column: "ImagePath",
                value: "wwwroot/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5,
                column: "ImagePath",
                value: "wwwroot/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6,
                column: "ImagePath",
                value: "wwwroot/images/súpa.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7,
                column: "ImagePath",
                value: "wwwroot/images/súpa.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8,
                column: "ImagePath",
                value: "wwwroot/images/grænn.JPG");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 9,
                column: "ImagePath",
                value: "wwwroot/images/lamb.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 10,
                column: "ImagePath",
                value: "wwwroot/images/naggar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 11,
                column: "ImagePath",
                value: "wwwroot/images/humar.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 12,
                column: "ImagePath",
                value: "wwwroot/images/dessert.jpg");
        }
    }
}
