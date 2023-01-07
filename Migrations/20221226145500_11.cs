using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class _11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53b0cea9-12cb-4a8a-848f-8a29e921bb23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8acc498-ba25-46cb-9a8f-15d9dd5a02e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e1656d20-0644-4d36-9b2e-94050860f9fc", null, "Administrator", "ADMINISTRATOR" },
                    { "e2e2d2bd-511a-45d9-a98b-70ae98b4097d", null, "User", "USER" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "e1656d20-0644-4d36-9b2e-94050860f9fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2e2d2bd-511a-45d9-a98b-70ae98b4097d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "53b0cea9-12cb-4a8a-848f-8a29e921bb23", null, "Administrator", "ADMINISTRATOR" },
                    { "a8acc498-ba25-46cb-9a8f-15d9dd5a02e2", null, "User", "USER" }
                });
        }
    }
}
