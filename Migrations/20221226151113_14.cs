using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Drinks_DrinkId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_DrinkId",
                table: "OrderItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "430c5055-a86f-4caa-8067-24d692583283");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "939c9106-4f8d-4a89-9a92-9ab9f6334d92");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "Drinks",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33af6bb8-10c0-462f-b8a9-95934ac0a872", null, "Administrator", "ADMINISTRATOR" },
                    { "ecd721d0-8a83-4550-82e7-6a4be2ac1597", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 1,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 2,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 3,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 4,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 5,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 6,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 7,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 8,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 9,
                column: "OrderItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 10,
                column: "OrderItemId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_OrderItemId",
                table: "Drinks",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_OrderItems_OrderItemId",
                table: "Drinks",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "OrderItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_OrderItems_OrderItemId",
                table: "Drinks");

            migrationBuilder.DropIndex(
                name: "IX_Drinks_OrderItemId",
                table: "Drinks");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33af6bb8-10c0-462f-b8a9-95934ac0a872");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecd721d0-8a83-4550-82e7-6a4be2ac1597");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "Drinks");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "430c5055-a86f-4caa-8067-24d692583283", null, "User", "USER" },
                    { "939c9106-4f8d-4a89-9a92-9ab9f6334d92", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DrinkId",
                table: "OrderItems",
                column: "DrinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Drinks_DrinkId",
                table: "OrderItems",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "DrinkId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
