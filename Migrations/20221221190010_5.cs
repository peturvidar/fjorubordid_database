using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdf8c4d4-8b46-4e5d-aaf4-ee6483334875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d018e70e-a170-4aae-9cce-ef0192470813");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e60152f-7441-45ad-a926-155ac8f90587", null, "Administrator", "ADMINISTRATOR" },
                    { "8aa66b77-a31b-4b2d-81eb-3b8c4f4fbbff", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "bdf8c4d4-8b46-4e5d-aaf4-ee6483334875", null, "Administrator", "ADMINISTRATOR" },
                    { "d018e70e-a170-4aae-9cce-ef0192470813", null, "User", "USER" }
                });
        }
    }
}
