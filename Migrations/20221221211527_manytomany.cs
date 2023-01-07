using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11b7602e-a7d9-40dc-a27d-fb89860574bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e533d800-8cd2-4800-b6ad-6be60dcab357");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "11b7602e-a7d9-40dc-a27d-fb89860574bd", null, "User", "USER" },
                    { "e533d800-8cd2-4800-b6ad-6be60dcab357", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
