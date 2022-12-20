using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fjorubordiddatabase.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    DrinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.DrinkId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    DrinkId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "Description", "Name", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Egils Gull 0.5l", "Egils Gull 0.5l", 1, 1400 },
                    { 2, "Egils Gull 0.3l", "Egils Gull 0.3l", 1, 1200 },
                    { 3, "Flaska af hvítvíni hússins", "Hvítvín hússins", 1, 7200 },
                    { 4, "Flaska af rauðvíni hússins", "Rauðvín hússins", 1, 7200 },
                    { 5, "Pepsi í gleri 330ml", "Pepsi", 1, 500 },
                    { 6, "Pepsi í gleri 330ml", "Pepsi Max", 1, 500 },
                    { 7, "7up í gleri 330ml", "7up", 1, 500 },
                    { 8, "Appelsín í gleri 330ml", "Appelsín", 1, 500 },
                    { 9, "Kristall í gleri 330ml án bragðefna", "Kristall", 1, 500 },
                    { 10, "Sleipnir Pale Ale frá Ölvisholt Brugghús 330ml", "Sleipnir Pale Ale", 1, 1600 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "Image", "Name", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "3ja rétta 400g", null, "3ja rétta 400g", 1, 14175 },
                    { 2, "3ja rétta 300g", null, "3ja rétta 300g", 1, 12250 },
                    { 3, "Leturhumar 400g", null, "Humar 400g", 1, 10750 },
                    { 4, "Leturhumar 300g", null, "Humar 300g", 1, 8650 },
                    { 5, "Leturhumar 250g", null, "Humar 250g", 1, 8050 },
                    { 6, "Aðalréttur", null, "Humarsúpa", 1, 4190 },
                    { 7, "Forréttur", null, "Humarsúpa", 1, 3250 },
                    { 8, "Grænmetisréttur", null, "Grænmetisréttur", 1, 4190 },
                    { 9, "Lambahryggvöðvi", null, "Lambahryggvöðvi", 1, 6250 },
                    { 10, "Barnamatseðill", null, "Kjúklinganaggar", 1, 990 },
                    { 11, "Barnamatseðill", null, "Samloka", 1, 990 },
                    { 12, "Eftirréttur tertusneið", null, "Eftirréttur", 1, 1650 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "OrderItems");
        }
    }
}
