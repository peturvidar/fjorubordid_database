using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81fcd48e-9d27-47b4-8d5f-ca930ea43451");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d138a5a6-7832-491c-a193-3aa8c71b4fa8");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04a78a17-a98d-4a42-a544-5b364b6fda10", null, "Administrator", "ADMINISTRATOR" },
                    { "e20d5b43-0572-4b4b-8cb8-7b2fa40fe93f", null, "User", "USER" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04a78a17-a98d-4a42-a544-5b364b6fda10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e20d5b43-0572-4b4b-8cb8-7b2fa40fe93f");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Foods");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "81fcd48e-9d27-47b4-8d5f-ca930ea43451", null, "Administrator", "ADMINISTRATOR" },
                    { "d138a5a6-7832-491c-a193-3aa8c71b4fa8", null, "User", "USER" }
                });
        }
    }
}
