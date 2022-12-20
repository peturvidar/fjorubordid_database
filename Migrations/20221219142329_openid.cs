using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class openid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "899bab9a-0a4a-4b10-ba0e-d2911166c319");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f546ffcc-90aa-4e99-a3eb-1456cc775803");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d5a99523-3960-4dc1-8ab9-62a35fd83c4e", null, "Administrator", "ADMINISTRATOR" },
                    { "e84461d1-7138-4473-8a4b-a7c69d688037", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5a99523-3960-4dc1-8ab9-62a35fd83c4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e84461d1-7138-4473-8a4b-a7c69d688037");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "899bab9a-0a4a-4b10-ba0e-d2911166c319", null, "Administrator", "ADMINISTRATOR" },
                    { "f546ffcc-90aa-4e99-a3eb-1456cc775803", null, "User", "USER" }
                });
        }
    }
}
