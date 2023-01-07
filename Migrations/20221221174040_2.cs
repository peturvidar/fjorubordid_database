using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e2911b3-f4e0-46f5-8933-7a1a457e5052");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81a762c7-66e4-4d3c-bafb-36f15333513c");

            migrationBuilder.AddColumn<string>(
                name: "ApiUserId",
                table: "OrderItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "OrderItems",
                type: "nvarchar(max)",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OrderItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7e2911b3-f4e0-46f5-8933-7a1a457e5052", null, "Administrator", "ADMINISTRATOR" },
                    { "81a762c7-66e4-4d3c-bafb-36f15333513c", null, "User", "USER" }
                });
        }
    }
}
