using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e60152f-7441-45ad-a926-155ac8f90587");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aa66b77-a31b-4b2d-81eb-3b8c4f4fbbff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11b7602e-a7d9-40dc-a27d-fb89860574bd", null, "User", "USER" },
                    { "e533d800-8cd2-4800-b6ad-6be60dcab357", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11b7602e-a7d9-40dc-a27d-fb89860574bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e533d800-8cd2-4800-b6ad-6be60dcab357");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e60152f-7441-45ad-a926-155ac8f90587", null, "Administrator", "ADMINISTRATOR" },
                    { "8aa66b77-a31b-4b2d-81eb-3b8c4f4fbbff", null, "User", "USER" }
                });
        }
    }
}
