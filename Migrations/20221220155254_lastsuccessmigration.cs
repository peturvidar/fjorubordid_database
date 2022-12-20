using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class lastsuccessmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3a11fc5-decf-4936-8d77-8cf3adc4651d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db0e6385-9db9-4d97-a96c-8ff1dd8007f5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dacc62b4-479a-4c8b-b11e-c3213b7efe97", null, "User", "USER" },
                    { "e3bdffad-257d-4477-aa63-eb48350731cc", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dacc62b4-479a-4c8b-b11e-c3213b7efe97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3bdffad-257d-4477-aa63-eb48350731cc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d3a11fc5-decf-4936-8d77-8cf3adc4651d", null, "Administrator", "ADMINISTRATOR" },
                    { "db0e6385-9db9-4d97-a96c-8ff1dd8007f5", null, "User", "USER" }
                });
        }
    }
}
