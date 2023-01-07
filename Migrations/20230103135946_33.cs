using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5b49fb04-66e5-4c56-934f-2e2fc530ac7c", null, "Administrator", "ADMINISTRATOR" },
                    { "e1be8d5c-3d6f-4087-96e3-036edcfbda3d", null, "User", "USER" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "1bbb4ca9-551a-4e73-ad2b-6f599cdc6e5e", null, "Administrator", "ADMINISTRATOR" },
                    { "4919ebf5-28df-416d-a25f-6b1182b2d60b", null, "User", "USER" }
                });

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
        }
    }
}
