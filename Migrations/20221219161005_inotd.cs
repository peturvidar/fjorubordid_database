using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class inotd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71494065-e361-4de1-9614-33cd90b3edf7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c51218bf-99eb-49ac-beec-f62807a4ece0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a4658db4-5938-449f-acc4-429bffeebf9e", null, "Administrator", "ADMINISTRATOR" },
                    { "a9fc3683-b963-4afa-9dcd-7ff408c4fb1c", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4658db4-5938-449f-acc4-429bffeebf9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9fc3683-b963-4afa-9dcd-7ff408c4fb1c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71494065-e361-4de1-9614-33cd90b3edf7", null, "User", "USER" },
                    { "c51218bf-99eb-49ac-beec-f62807a4ece0", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
