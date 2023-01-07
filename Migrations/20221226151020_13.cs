using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Foods_FoodId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_FoodId",
                table: "OrderItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e9d2de3-dc1f-4ec8-9562-0f6882303a77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2fb2a62-0249-4bf2-8fac-cf57879039d4");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "430c5055-a86f-4caa-8067-24d692583283", null, "User", "USER" },
                    { "939c9106-4f8d-4a89-9a92-9ab9f6334d92", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 9,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 10,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 11,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 12,
                column: "OrderItemId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_OrderItemId",
                table: "Foods",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_OrderItems_OrderItemId",
                table: "Foods",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "OrderItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_OrderItems_OrderItemId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_OrderItemId",
                table: "Foods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "430c5055-a86f-4caa-8067-24d692583283");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "939c9106-4f8d-4a89-9a92-9ab9f6334d92");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "Foods");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9e9d2de3-dc1f-4ec8-9562-0f6882303a77", null, "Administrator", "ADMINISTRATOR" },
                    { "c2fb2a62-0249-4bf2-8fac-cf57879039d4", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FoodId",
                table: "OrderItems",
                column: "FoodId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Foods_FoodId",
                table: "OrderItems",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
