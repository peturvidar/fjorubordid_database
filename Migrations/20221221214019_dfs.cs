using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class dfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Foods_FoodsFoodId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_FoodsFoodId",
                table: "OrderItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d411ee6d-9ef2-4546-aa06-f44a198cb16e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0f642f5-fd85-4263-81c7-8412c3daff2f");

            migrationBuilder.DropColumn(
                name: "FoodsFoodId",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "53b0cea9-12cb-4a8a-848f-8a29e921bb23", null, "Administrator", "ADMINISTRATOR" },
                    { "a8acc498-ba25-46cb-9a8f-15d9dd5a02e2", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FoodId",
                table: "OrderItems",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Foods_FoodId",
                table: "OrderItems",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "53b0cea9-12cb-4a8a-848f-8a29e921bb23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8acc498-ba25-46cb-9a8f-15d9dd5a02e2");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "FoodsFoodId",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d411ee6d-9ef2-4546-aa06-f44a198cb16e", null, "Administrator", "ADMINISTRATOR" },
                    { "e0f642f5-fd85-4263-81c7-8412c3daff2f", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FoodsFoodId",
                table: "OrderItems",
                column: "FoodsFoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Foods_FoodsFoodId",
                table: "OrderItems",
                column: "FoodsFoodId",
                principalTable: "Foods",
                principalColumn: "FoodId");
        }
    }
}
