using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33af6bb8-10c0-462f-b8a9-95934ac0a872");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecd721d0-8a83-4550-82e7-6a4be2ac1597");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0369e50a-ba4c-4a9e-bb66-1afe481f4a73", null, "User", "USER" },
                    { "cd8acbd5-ca63-4751-b93a-306e5fab1028", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "33af6bb8-10c0-462f-b8a9-95934ac0a872", null, "Administrator", "ADMINISTRATOR" },
                    { "ecd721d0-8a83-4550-82e7-6a4be2ac1597", null, "User", "USER" }
                });
        }
    }
}
