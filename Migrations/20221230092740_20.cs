using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0369e50a-ba4c-4a9e-bb66-1afe481f4a73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd8acbd5-ca63-4751-b93a-306e5fab1028");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e74bd76f-bd68-4e5f-a2e2-6ff1d53b89a5", null, "Administrator", "ADMINISTRATOR" },
                    { "f36c7db0-b085-4a7c-81e2-2cdd80f48a95", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e74bd76f-bd68-4e5f-a2e2-6ff1d53b89a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f36c7db0-b085-4a7c-81e2-2cdd80f48a95");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0369e50a-ba4c-4a9e-bb66-1afe481f4a73", null, "User", "USER" },
                    { "cd8acbd5-ca63-4751-b93a-306e5fab1028", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
