using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _36 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9e7b892-659f-4db4-aaeb-81c030ee4488");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5ecb54d-1b63-4097-9e27-1c89683f8f0e");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Drinks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "53a83e4b-20fb-40a9-b1d7-30d3382de6d4", null, "Administrator", "ADMINISTRATOR" },
                    { "6565a8aa-1d74-485a-a7bf-a3a9bd3fcb95", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 1,
                column: "ImagePath",
                value: "gull.png");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 2,
                column: "ImagePath",
                value: "gull.png");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 3,
                column: "ImagePath",
                value: "white.jpg");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 4,
                column: "ImagePath",
                value: "red.png");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 5,
                column: "ImagePath",
                value: "pepsi.jpg");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 6,
                column: "ImagePath",
                value: "pepsimax.jpg");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 7,
                column: "ImagePath",
                value: "7up.jpg");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 8,
                column: "ImagePath",
                value: "appelsin.png");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 9,
                column: "ImagePath",
                value: "kristall.jpg");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 10,
                column: "ImagePath",
                value: "sleipnir.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 11,
                column: "ImagePath",
                value: "samloka.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53a83e4b-20fb-40a9-b1d7-30d3382de6d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6565a8aa-1d74-485a-a7bf-a3a9bd3fcb95");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Drinks");

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
                keyValue: 11,
                column: "ImagePath",
                value: "humar.jpg");
        }
    }
}
