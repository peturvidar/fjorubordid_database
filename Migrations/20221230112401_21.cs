using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e74bd76f-bd68-4e5f-a2e2-6ff1d53b89a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f36c7db0-b085-4a7c-81e2-2cdd80f48a95");

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "41632f86-33a8-4d2b-8808-f7f0ffc7f828", null, "Administrator", "ADMINISTRATOR" },
                    { "a581d980-aac5-4684-af39-009c516cf736", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41632f86-33a8-4d2b-8808-f7f0ffc7f828");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a581d980-aac5-4684-af39-009c516cf736");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e74bd76f-bd68-4e5f-a2e2-6ff1d53b89a5", null, "Administrator", "ADMINISTRATOR" },
                    { "f36c7db0-b085-4a7c-81e2-2cdd80f48a95", null, "User", "USER" }
                });
        }
    }
}
