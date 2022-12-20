using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class open1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "368b54ef-c301-4d7c-b900-78a889c55131");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d70234e2-3b44-4373-af6c-1dd918a9d882");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "899bab9a-0a4a-4b10-ba0e-d2911166c319", null, "Administrator", "ADMINISTRATOR" },
                    { "f546ffcc-90aa-4e99-a3eb-1456cc775803", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "368b54ef-c301-4d7c-b900-78a889c55131", null, "User", "USER" },
                    { "d70234e2-3b44-4373-af6c-1dd918a9d882", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
