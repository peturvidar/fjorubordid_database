using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class inidd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f35eaed-fc2a-42d6-a706-d59529a838f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "761905ea-eb79-45ca-a2b4-3092a1b56ded");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76c3563e-f5e3-475e-9c57-0cab66e8d19f", null, "User", "USER" },
                    { "809ccd51-d715-448b-b57d-d0f34d92f375", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76c3563e-f5e3-475e-9c57-0cab66e8d19f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "809ccd51-d715-448b-b57d-d0f34d92f375");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f35eaed-fc2a-42d6-a706-d59529a838f9", null, "User", "USER" },
                    { "761905ea-eb79-45ca-a2b4-3092a1b56ded", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
