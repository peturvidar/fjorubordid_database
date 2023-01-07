using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _40 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53a83e4b-20fb-40a9-b1d7-30d3382de6d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6565a8aa-1d74-485a-a7bf-a3a9bd3fcb95");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "477dada8-ca27-4b60-84d3-82fc830dbd78", null, "User", "USER" },
                    { "aa540fd0-9dac-40e0-8e78-f081bc9729c4", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "477dada8-ca27-4b60-84d3-82fc830dbd78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa540fd0-9dac-40e0-8e78-f081bc9729c4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "53a83e4b-20fb-40a9-b1d7-30d3382de6d4", null, "Administrator", "ADMINISTRATOR" },
                    { "6565a8aa-1d74-485a-a7bf-a3a9bd3fcb95", null, "User", "USER" }
                });
        }
    }
}
