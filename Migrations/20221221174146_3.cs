using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_AspNetUsers_ApiUserId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ApiUserId",
                table: "OrderItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28b7178c-95d5-45fd-ad4c-e2ff779b162f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9fceb17-f71f-43d0-a75a-5c8bf6f20685");

            migrationBuilder.DropColumn(
                name: "ApiUserId",
                table: "OrderItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bdf8c4d4-8b46-4e5d-aaf4-ee6483334875", null, "Administrator", "ADMINISTRATOR" },
                    { "d018e70e-a170-4aae-9cce-ef0192470813", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdf8c4d4-8b46-4e5d-aaf4-ee6483334875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d018e70e-a170-4aae-9cce-ef0192470813");

            migrationBuilder.AddColumn<string>(
                name: "ApiUserId",
                table: "OrderItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28b7178c-95d5-45fd-ad4c-e2ff779b162f", null, "User", "USER" },
                    { "c9fceb17-f71f-43d0-a75a-5c8bf6f20685", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ApiUserId",
                table: "OrderItems",
                column: "ApiUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_AspNetUsers_ApiUserId",
                table: "OrderItems",
                column: "ApiUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
