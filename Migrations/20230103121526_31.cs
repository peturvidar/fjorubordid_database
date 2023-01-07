using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04a78a17-a98d-4a42-a544-5b364b6fda10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e20d5b43-0572-4b4b-8cb8-7b2fa40fe93f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a0c29bf-b160-43d2-a6a7-5e5acbbad82c", null, "User", "USER" },
                    { "9a2b6d2c-f205-44e5-876b-a3c438de01ec", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "04a78a17-a98d-4a42-a544-5b364b6fda10", null, "Administrator", "ADMINISTRATOR" },
                    { "e20d5b43-0572-4b4b-8cb8-7b2fa40fe93f", null, "User", "USER" }
                });
        }
    }
}
