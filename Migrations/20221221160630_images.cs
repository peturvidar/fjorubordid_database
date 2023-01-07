using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class images : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73adaf6f-2bf4-4be3-871d-a167790e95f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d15998cf-4e83-408d-9a84-5a64ed40b44a");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 12);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a8d2e9cc-9825-4a73-8b11-551d61cc7e30", null, "Administrator", "ADMINISTRATOR" },
                    { "d284ff29-e0ca-4d2c-aa02-23ab2158dbc5", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                column: "Image",
                value: "wwwroot\\Images\\humar.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8d2e9cc-9825-4a73-8b11-551d61cc7e30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d284ff29-e0ca-4d2c-aa02-23ab2158dbc5");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Foods");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73adaf6f-2bf4-4be3-871d-a167790e95f1", null, "Administrator", "ADMINISTRATOR" },
                    { "d15998cf-4e83-408d-9a84-5a64ed40b44a", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "Name", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 2, "3ja rétta 300g", "3ja rétta 300g", 1, 12250 },
                    { 3, "Leturhumar 400g", "Humar 400g", 1, 10750 },
                    { 4, "Leturhumar 300g", "Humar 300g", 1, 8650 },
                    { 5, "Leturhumar 250g", "Humar 250g", 1, 8050 },
                    { 6, "Aðalréttur", "Humarsúpa", 1, 4190 },
                    { 7, "Forréttur", "Humarsúpa", 1, 3250 },
                    { 8, "Grænmetisréttur", "Grænmetisréttur", 1, 4190 },
                    { 9, "Lambahryggvöðvi", "Lambahryggvöðvi", 1, 6250 },
                    { 10, "Barnamatseðill", "Kjúklinganaggar", 1, 990 },
                    { 11, "Barnamatseðill", "Samloka", 1, 990 },
                    { 12, "Eftirréttur tertusneið", "Eftirréttur", 1, 1650 }
                });
        }
    }
}
