using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_Productos_Pedidos.Migrations
{
    /// <inheritdoc />
    public partial class TablesSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Devices and gadgets", "Electronics" },
                    { 2, "Things for the home", "Home" },
                    { 3, "Men's and women's clothing", "Clothing" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "category_id", "description", "name", "price", "stock" },
                values: new object[,]
                {
                    { 1, 1, "Latest model smartphone with 5G support", "Smartphone", 699.99000000000001, 50 },
                    { 2, 1, "High performance laptop for gaming", "Laptop", 999.99000000000001, 30 },
                    { 3, 3, "100% cotton T-shirt available in various colors", "T-shirt", 10.99, 100 },
                    { 4, 3, "Comfortable blue jeans, available in multiple sizes", "Jeans", 39.990000000000002, 50 },
                    { 5, 2, "leather furniture", "Furniture", 210.99000000000001, 20 },
                    { 6, 2, "large round mirror", "Mirror", 20.5, 85 },
                    { 7, 1, "Noise-cancelling headphones with Bluetooth", "Headphones", 149.99000000000001, 40 },
                    { 8, 3, "Winter jacket to keep you warm", "Jacket", 89.989999999999995, 25 },
                    { 9, 2, "Large black refrigerator", "Refrigerator", 234.19999999999999, 18 },
                    { 10, 2, "Extra large bed", "Bed", 120.5, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
