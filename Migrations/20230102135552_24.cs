using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41632f86-33a8-4d2b-8808-f7f0ffc7f828");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a581d980-aac5-4684-af39-009c516cf736");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "81fcd48e-9d27-47b4-8d5f-ca930ea43451", null, "Administrator", "ADMINISTRATOR" },
                    { "d138a5a6-7832-491c-a193-3aa8c71b4fa8", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81fcd48e-9d27-47b4-8d5f-ca930ea43451");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d138a5a6-7832-491c-a193-3aa8c71b4fa8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "41632f86-33a8-4d2b-8808-f7f0ffc7f828", null, "Administrator", "ADMINISTRATOR" },
                    { "a581d980-aac5-4684-af39-009c516cf736", null, "User", "USER" }
                });
        }
    }
}
